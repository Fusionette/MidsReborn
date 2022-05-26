using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using mrbBase;
using mrbBase.Base.Master_Classes;
using Newtonsoft.Json;

namespace Mids_Reborn
{
    public static class clsGenFreebies
    {
        private const int EnhancementsTrayCapacity = 70;
        private const string BoostCmd = "boost";
        private const string CmdSeparator = "$$";
        private const bool AutoAttune = false;
        public static string MenuName { get; set; } = "MRBTest";
        public const string MenuExt = "mnu";

        public static void GenerateJson()
        {
            var jc = new MidsJsonCharacter
            {
                Name = MidsContext.Character.Name,
                Class = MidsContext.Character.Archetype.ClassName,
                Origin = MidsContext.Character.Archetype.Origin[MidsContext.Character.Origin]
            };

            // For any integers in the JSON we use nullable ints and avoid populating them if zero,
            // this makes the export blob slightly smaller.
            if (MidsContext.Character.Level > 0) jc.Level = MidsContext.Character.Level;

            foreach (var p in MidsContext.Character.CurrentBuild.Powers)
            {
                if (p.Power == null) continue;

                if (jc.Powers == null) jc.Powers = new List<MidsJsonPower>();
                var jp = new MidsJsonPower
                {
                    // a live release shouldn't have to do this.
                    // again this is intended for beta testing only,
                    // Use the power name from PowerTranslations if it exists;
                    PowerFullName = DatabaseAPI.Database.CrypticReplTable.KeyExists(p.Power.FullName)
                        ? DatabaseAPI.Database.CrypticReplTable.FetchAlternate(p.Power.FullName)
                        : p.Power.FullName
                };

                if (p.Level > 0) jp.PowerLevelBought = p.Level;

                for (var j = 0; j < p.Slots.Length; j++)
                {
                    if (p.Slots[j].Enhancement.Enh < 0) continue;
                    jp.Boosts ??= new List<MidsJsonBoost>();

                    var jb = new MidsJsonBoost();
                    var boost = p.Slots[j].Enhancement;
                    jb.BoostName = DatabaseAPI.Database.Enhancements[boost.Enh].UID;

                    // The RelativeLevel field is used to set the level of standard enhancements
                    // and as the value of NumCombines in crafted enhancements.
                    var rl = boost.RelativeLevel switch
                    {
                        Enums.eEnhRelative.MinusThree => -3,
                        Enums.eEnhRelative.MinusTwo => -2,
                        Enums.eEnhRelative.MinusOne => -1,
                        Enums.eEnhRelative.PlusOne => 1,
                        Enums.eEnhRelative.PlusTwo => 2,
                        Enums.eEnhRelative.PlusThree => 3,
                        Enums.eEnhRelative.PlusFour => 4,
                        Enums.eEnhRelative.PlusFive => 5,
                        _ => 0
                    };

                    // FIXME: boost.Grade is an Enums.eEnhGrade but that doesn't contain IOs.
                    // I just assume it's an IO if there's an IOLevel.
                    if (boost.IOLevel > 0)
                    {
                        // This is a crafted enhancement. Use the relative level as NumCombines.
                        jb.Level = boost.IOLevel;
                        if (rl > 0) jb.NumCombines = rl;
                    }
                    else
                    {
                        // This is a standard enhancement. Set the level to the character level + boost relative level.
                        if (jc.Level + rl > 0) jb.Level = jc.Level + rl;
                    }

                    jp.Boosts.Add(jb);
                }

                jc.Powers.Add(jp);
            }

            Clipboard.SetDataObject(jc.ToString(), true);
        }

        private static List<List<string>> GenerateBoostChunks()
        {
            var k = 0;
            var l = 0;
            var commandChunks = new List<List<string>>();

            foreach (var p in MidsContext.Character.CurrentBuild.Powers.Where(p => p.State != Enums.ePowerState.Empty))
            {
                for (var j = 0; j < p.Slots.Length; j++)
                {
                    if (p.Slots[j].Enhancement.Enh < 0) continue; // Empty slot
                    if (k % EnhancementsTrayCapacity == 0)
                    {
                        commandChunks.Add(new List<string>());
                        if (k > 0) l++;
                    }

                    var enhData = DatabaseAPI.Database.Enhancements[p.Slots[j].Enhancement.Enh];
                    var enhUid = enhData.UID.Replace("Shrapnel_", "Artillery_");
                    var setLevelMax = enhData.nIDSet > -1
                        ? DatabaseAPI.Database.EnhancementSets[enhData.nIDSet].LevelMax
                        : 49;
                    var enhBoostLevel = enhData.LevelMax + 1;
                    if (enhData.nIDSet > -1 & AutoAttune & setLevelMax < 49)
                    {
                        enhUid = enhData.UID.Replace("Crafted_", "Attuned_");
                        enhBoostLevel = 1;
                    }

                    commandChunks[l].Add($"{BoostCmd} {enhUid} {enhUid} {enhBoostLevel}");

                    k++;
                }
            }

            return commandChunks;
        }

        public static string GenerateMenu()
        {
            if (MainModule.MidsController.Toon == null) return string.Empty;

            var commandChunks = GenerateBoostChunks();
            var dateTag = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", null);
            var mnuStr = $"// Generated by {Application.ProductName} v{Application.ProductVersion} - {dateTag}\r\n";
            mnuStr += $"// Open the menu ingame: /popmenu {MenuName}\r\n\r\n";
            mnuStr += $"Menu \"{MenuName}\"\r\n";
            mnuStr += "{\r\n";
            mnuStr += $"\tTitle \"{(string.IsNullOrWhiteSpace(MainModule.MidsController.Toon.Name) ? "Test build" : $"{MainModule.MidsController.Toon.Name.Trim()} test build")}\"\r\n";
            mnuStr += "\tDIVIDER\r\n";

            for (var i = 0; i < commandChunks.Count; i++)
            {
                mnuStr += $"\tOption \"Give enhancements (part {i + 1})\" \"{string.Join(CmdSeparator, commandChunks[i].ToArray())}\"\r\n";
            }

            mnuStr += "\tDIVIDER\r\n";
            mnuStr += "\tLockedOption\r\n";
            mnuStr += "\t{\r\n";
            mnuStr += $"\t\tDisplayName \"{Application.ProductName} v{Application.ProductVersion}\"\r\n";
            mnuStr += "\t\tBadge \"X\"\r\n";
            mnuStr += "\t}\r\n";
            mnuStr += "\tLockedOption\r\n";
            mnuStr += "\t{\r\n";
            mnuStr += $"\t\tDisplayName \"Generated: {dateTag}\"\r\n";
            mnuStr += "\t\tBadge \"X\"\r\n";
            mnuStr += "\t}\r\n";
            mnuStr += "}";

            return mnuStr;
        }

        public static bool SaveTo(string file)
        {
            var mnuStr = GenerateMenu();
            if (string.IsNullOrEmpty(mnuStr)) return false;
            try
            {
                using var sw = new StreamWriter(file);
                sw.Write(mnuStr);
                sw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}