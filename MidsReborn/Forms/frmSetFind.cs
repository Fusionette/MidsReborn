using System.Diagnostics;
using System.Runtime.CompilerServices;
using MidsReborn.Base;
using MidsReborn.Base.Base.Data_Classes;
using MidsReborn.Base.Base.Display;
using MidsReborn.Base.Base.Extensions;
using MidsReborn.Base.Base.Master_Classes;
using MidsReborn.Controls;

namespace MidsReborn.Forms
{
    public partial class frmSetFind : Form
    {
        private readonly frmMain myParent;

        private ImageButton ibClose;
        private ImageButton ibTopmost;
        private int[] setBonusList;
        private ctlPopUp SetInfo;

        public frmSetFind(frmMain iParent)
        {
            FormClosed += frmSetFind_FormClosed;
            Load += frmSetFind_Load;
            setBonusList = new int[0];
            InitializeComponent();
            //var componentResourceManager = new ComponentResourceManager(typeof(frmSetFind));
            Icon = Resources.reborn;
            Name = nameof(frmSetFind);
            ibClose.ButtonClicked += ibClose_ButtonClicked;
            ibTopmost.ButtonClicked += ibTopmost_ButtonClicked;
            myParent = iParent;
        }

        private void AddEffect(ref string[] list, ref int[] nIDList, string effect, int nID)
        {
            var num = list.Length - 1;
            for (var index = 0; index <= num; ++index)
            {
                if (string.Equals(list[index], effect, StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }
            }

            Array.Resize(ref list, list.Length + 1);
            Array.Resize(ref nIDList, nIDList.Length + 1);
            list[list.Length - 1] = effect;
            nIDList[list.Length - 1] = nID;
        }

        private void AddSetString(int nIDSet, int BonusID)
        {
            lvSet.Items.Add(new ListViewItem(new[]
            {
                DatabaseAPI.Database.EnhancementSets[nIDSet].DisplayName,
                Convert.ToString(DatabaseAPI.Database.EnhancementSets[nIDSet].LevelMin + 1) + " - " +
                Convert.ToString(DatabaseAPI.Database.EnhancementSets[nIDSet].LevelMax + 1),
                DatabaseAPI.Database.SetTypeStringLong[(int) DatabaseAPI.Database.EnhancementSets[nIDSet].SetType],
                BonusID >= 0
                    ? Convert.ToString(DatabaseAPI.Database.EnhancementSets.GetSetBonusEnhCount(nIDSet, BonusID))
                    : "Special"
            }, nIDSet));
            lvSet.Items[lvSet.Items.Count - 1].Tag = nIDSet;
        }

        private void FillEffectList()
        {
            var List = Array.Empty<string>();
            var nIDList = Array.Empty<int>();
            lvBonus.BeginUpdate();
            lvBonus.Items.Clear();
            var num1 = setBonusList.Length - 1;
            for (var index = 0; index <= num1; ++index)
                if ((DatabaseAPI.Database.Power[setBonusList[index]].EntitiesAutoHit & Enums.eEntity.Caster) >
                    Enums.eEntity.None)
                    AddEffect(ref List, ref nIDList, GetPowerString(setBonusList[index]), -1);
            var num2 = List.Length - 1;
            for (var index = 0; index <= num2; ++index)
                lvBonus.Items.Add(new ListViewItem(List[index]));
            lvBonus.Sorting = SortOrder.Ascending;
            lvBonus.Sort();
            if (lvBonus.Items.Count > 0)
                lvBonus.Items[0].Selected = true;
            lvBonus.EndUpdate();
        }

        private void FillImageList()
        {
            var imageSize1 = ilSets.ImageSize;
            var width1 = imageSize1.Width;
            imageSize1 = ilSets.ImageSize;
            var height1 = imageSize1.Height;
            using var extendedBitmap = new ExtendedBitmap(width1, height1);
            ilSets.Images.Clear();
            var num = DatabaseAPI.Database.EnhancementSets.Count;
            for (var index = 0; index < num; index++)
                if (DatabaseAPI.Database.EnhancementSets[index].ImageIdx > -1)
                {
                    extendedBitmap.Graphics.Clear(Color.Transparent);
                    var graphics = extendedBitmap.Graphics;
                    I9Gfx.DrawEnhancementSet(ref graphics, DatabaseAPI.Database.EnhancementSets[index].ImageIdx);
                    ilSets.Images.Add(extendedBitmap.Bitmap);
                }
                else
                {
                    var images = ilSets.Images;
                    var imageSize2 = ilSets.ImageSize;
                    var width2 = imageSize2.Width;
                    imageSize2 = ilSets.ImageSize;
                    var height2 = imageSize2.Height;
                    var bitmap = new Bitmap(width2, height2);
                    images.Add(bitmap);
                }
        }

        private void FillMagList()
        {
            if (lvBonus.SelectedItems.Count < 1)
            {
                lvMag.Items.Clear();
            }
            else
            {
                var List = Array.Empty<string>();
                var nIDList = Array.Empty<int>();
                var text = lvBonus.SelectedItems[0].Text;
                var num1 = setBonusList.Length - 1;
                for (var index = 0; index <= num1; ++index)
                {
                    if (DatabaseAPI.Database.Power[setBonusList[index]].Effects.Length <= 0)
                        continue;
                    var powerString = GetPowerString(setBonusList[index]);
                    if (text != powerString)
                        continue;

                    string effect;
                    if (DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].EffectType != Enums.eEffectType.HitPoints)
                    {
                        if (DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].EffectType != Enums.eEffectType.Endurance)
                        {
                            effect = $"{Convert.ToDecimal(DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].MagPercent):##0}";
                        }
                        else
                        {
                            effect = $"{Convert.ToDecimal(DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].Mag):##0}";
                        }
                    }
                    else
                    {
                        effect = $"{Convert.ToDecimal(DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].Mag / (double)MidsContext.Archetype.Hitpoints * 100.0):##0}%";
                    }


                    // var Effect = (DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].EffectType != Enums.eEffectType.HitPoints //condition
                    //         ? DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].EffectType != Enums.eEffectType.Endurance 
                    //             ? Strings.Format(DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].MagPercent, "##0" + NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "00")
                    //             : Strings.Format(DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].Mag, "##0" + NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "00")
                    //         : Strings.Format((float) (DatabaseAPI.Database.Power[setBonusList[index]].Effects[0].Mag / (double) MidsContext.Archetype.Hitpoints * 100.0), "##0" + NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "00")) + "%";
                    AddEffect(ref List, ref nIDList, effect, setBonusList[index]);
                }

                lvMag.BeginUpdate();
                lvMag.Items.Clear();
                lvMag.Items.Add("All");
                var num2 = List.Length - 1;
                for (var index = 0; index <= num2; ++index)
                    lvMag.Items.Add(new ListViewItem(List[index])
                    {
                        Tag = nIDList[index]
                    });
                if (lvMag.Items.Count > 0)
                    lvMag.Items[0].Selected = true;
                lvMag.EndUpdate();
            }
        }

        private void FillSetList()
        {
            if ((lvBonus.SelectedItems.Count < 1) | (lvMag.SelectedItems.Count < 1))
            {
                lvSet.Items.Clear();
            }
            else
            {
                lvSet.BeginUpdate();
                lvSet.Items.Clear();
                var List = Array.Empty<string>();
                var nIDList = Array.Empty<int>();
                var text = lvBonus.SelectedItems[0].Text;
                var flag = lvMag.Items[0].Selected;
                if (!flag)
                {
                    if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(lvMag.SelectedItems[0].Tag)) > -1.0)
                    {
                        AddEffect(ref List, ref nIDList, DatabaseAPI.Database.Power[Convert.ToInt32(lvMag.SelectedItems[0].Tag)].PowerName, Convert.ToInt32(lvMag.SelectedItems[0].Tag));
                    }
                }
                else
                {
                    var num = setBonusList.Length - 1;
                    for (var index = 0; index <= num; ++index)
                    {
                        if (DatabaseAPI.Database.Power[setBonusList[index]].Effects.Length <= 0)
                            continue;
                        var powerString = GetPowerString(setBonusList[index]);
                        if (text == powerString)
                            AddEffect(ref List, ref nIDList, DatabaseAPI.Database.Power[setBonusList[index]].PowerName,
                                setBonusList[index]);
                    }
                }

                var num1 = DatabaseAPI.Database.EnhancementSets.Count - 1;
                for (var nIDSet = 0; nIDSet <= num1; ++nIDSet)
                {
                    var num2 = DatabaseAPI.Database.EnhancementSets[nIDSet].Bonus.Length - 1;
                    for (var BonusID = 0; BonusID <= num2; ++BonusID)
                    {
                        var num3 = DatabaseAPI.Database.EnhancementSets[nIDSet].Bonus[BonusID].Index.Length - 1;
                        for (var index1 = 0; index1 <= num3; ++index1)
                        {
                            var num4 = nIDList.Length - 1;
                            for (var index2 = 0; index2 <= num4; ++index2)
                                if (DatabaseAPI.Database.EnhancementSets[nIDSet].Bonus[BonusID].Index[index1] ==
                                    nIDList[index2])
                                    AddSetString(nIDSet, BonusID);
                        }
                    }

                    var num5 = DatabaseAPI.Database.EnhancementSets[nIDSet].SpecialBonus.Length - 1;
                    for (var BonusID = 0; BonusID <= num5; ++BonusID)
                    {
                        var num3 = DatabaseAPI.Database.EnhancementSets[nIDSet].SpecialBonus[BonusID].Index.Length - 1;
                        for (var index1 = 0; index1 <= num3; ++index1)
                        {
                            var num4 = nIDList.Length - 1;
                            for (var index2 = 0; index2 <= num4; ++index2)
                                if (DatabaseAPI.Database.EnhancementSets[nIDSet].SpecialBonus[BonusID].Index[index1] ==
                                    nIDList[index2])
                                    AddSetString(nIDSet, BonusID);
                        }
                    }
                }

                if (lvSet.Items.Count > 0)
                    lvSet.Items[0].Selected = true;
                lvSet.EndUpdate();
            }
        }

        private void frmSetFind_FormClosed(object sender, FormClosedEventArgs e)
        {
            myParent.FloatSetFinder(false);
        }

        private void SetImageButtonStyle(ImageButton ib)
        {
            ib.IA = myParent.Drawing.pImageAttributes;
            ib.ImageOff = MidsContext.Character.IsHero()
                ? myParent.Drawing.bxPower[2].Bitmap
                : myParent.Drawing.bxPower[4].Bitmap;
            ib.ImageOn = MidsContext.Character.IsHero()
                ? myParent.Drawing.bxPower[3].Bitmap
                : myParent.Drawing.bxPower[5].Bitmap;
        }

        private void frmSetFind_Load(object sender, EventArgs e)
        {
            setBonusList = DatabaseAPI.NidPowers("Set_Bonus.Set_Bonus");
            BackColor = myParent.BackColor;
            SetImageButtonStyle(ibClose);
            SetImageButtonStyle(ibTopmost);
            SetInfo.SetPopup(new PopUp.PopupData());
            FillImageList();
            FillEffectList();
            FillArchetypesList();

            cbArchetype.SelectedIndex = 0;
        }

        private void FillArchetypesList()
        {
            //var ignoredClasses = Archetype.GetNpcClasses();
            //var classesList = DatabaseAPI.Database.Classes.Select(at => at.DisplayName);
            //var playerClasses = classesList.Except(ignoredClasses);
            var playerClasses = DatabaseAPI.Database.Classes
                .Where(at => at.Playable)
                .Select(at => at.DisplayName);

            cbArchetype.BeginUpdate();
            cbArchetype.Items.Clear();
            cbArchetype.Items.Add("--Archetype--");
            foreach (var c in playerClasses)
            {
                cbArchetype.Items.Add(c);
            }

            cbArchetype.EndUpdate();
        }

        private string GetPowerString(int nIDPower)
        {
            var str1 = "";
            var returnString = "";
            var returnMask = new int[0];
            DatabaseAPI.Database.Power[nIDPower]
                .GetEffectStringGrouped(0, ref returnString, ref returnMask, true, true, true);
            string str2;
            if (returnString != "")
            {
                str2 = returnString;
            }
            else
            {
                var num1 = DatabaseAPI.Database.Power[nIDPower].Effects.Length;
                for (var index1 = 0; index1 < num1; index1++)
                {
                    var flag = false;
                    var num2 = returnMask.Length;
                    for (var index2 = 0; index2 < num2; index2++)
                        if (index1 == returnMask[index2])
                            flag = true;

                    if (flag)
                        continue;
                    if (str1 != "")
                        str1 += ", ";
                    var str3 = DatabaseAPI.Database.Power[nIDPower].Effects[index1].BuildEffectString(true, "", true).Trim();
                    if (str3.Contains("Res("))
                        str3 = str3.Replace("Res(", "Resistance(");
                    if (str3.Contains("Def("))
                        str3 = str3.Replace("Def(", "Defense(");
                    if (str3.Contains("EndRec"))
                        str3 = str3.Replace("EndRec", "Recovery");
                    if (str3.Contains("Endurance"))
                        str3 = str3.Replace("Endurance", "Max End");
                    else if (str3.Contains("End") & !str3.Contains("Max End"))
                        str3 = str3.Replace("End", "Max End");
                    str1 += str3;
                }

                str2 = str1;
            }

            return str2;
        }

        private void ibClose_ButtonClicked()
        {
            Close();
        }

        private void ibTopmost_ButtonClicked()
        {
            TopMost = ibTopmost.Checked;
            if (!TopMost)
                return;
            BringToFront();
        }

        [DebuggerStepThrough]
        private void lvBonus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMagList();
        }

        private void lvMag_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSetList();
        }

        private void lvSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSet.SelectedItems.Count <= 0) return;

            var sIdx = Convert.ToInt32(lvSet.SelectedItems[0].Tag);
            SetInfo.SetPopup(Character.PopSetInfo(sIdx));
            FillMatchingPowers(sIdx);
        }

        private bool IsPeacebringerInherent(IPower power)
        {
            return power.GetPowerSet().SetName == "Inherent" &
                   (power.PowerName == "Energy_Flight" |
                    power.PowerName == "Combat_Flight" |
                    power.PowerName == "Quantum_Acceleration" |
                    power.PowerName.StartsWith("Bright_Nova") |
                    power.PowerName.StartsWith("White_Dwarf"));
        }

        private bool IsWarshadeInherent(IPower power)
        {
            return power.GetPowerSet().SetName == "Inherent" &
                   (power.PowerName == "Shadow_Recall" |
                    power.PowerName == "Shadow_Step" |
                    power.PowerName.StartsWith("Dark_Nova") |
                    power.PowerName.StartsWith("Black_Dwarf"));
        }


        private void FillMatchingPowers(int sIdx)
        {
            var enhSet = DatabaseAPI.Database.EnhancementSets[sIdx];
            var powerSetsIconsDict = new Dictionary<string, int>();
            var atIconsDict = new Dictionary<string, int>();
            var imgIdx = 0;

            var setGroup = enhSet.SetType;
            var atClass = cbArchetype.SelectedIndex < 1
                ? null
                : DatabaseAPI.GetArchetypeByName(cbArchetype.Items[cbArchetype.SelectedIndex].ToString());

            var matchingPowers = DatabaseAPI.Database.Power
                .Where(p => p.SetTypes.Contains(setGroup) &
                            !p.HiddenPower &
                            !p.FullName.StartsWith("Pets.") &
                            !p.FullName.StartsWith("Villain_Pets."))
                .ToList();

            if (matchingPowers.Count <= 0)
            {
                lvPowers.BeginUpdate();
                lvPowers.Items.Clear();
                lvPowers.EndUpdate();

                return;
            }

            var matchingPowersets = matchingPowers
                .Select(p => p.GetPowerSet())
                .Distinct()
                .ToList();
            
            var matchingPowersetsIdx = matchingPowersets
                .Select(ps => Array.IndexOf(DatabaseAPI.Database.Powersets, ps))
                .ToList();
            
            /*var matchingArchetypes = matchingPowers
                .Select(p => DatabaseAPI.Database.Classes
                    .FirstOrDefault(at => DatabaseAPI.Database.Powersets[p.PowerSetID].ATClass == at.ClassName))
                .Distinct()
                .ToList();
            matchingArchetypes =
                matchingArchetypes
                    .Union(new[] {"Peacebringer", "Warshade"}.Select(DatabaseAPI.GetArchetypeByName))
                    .Distinct()
                    .ToList();*/

            var matchingArchetypes = DatabaseAPI.Database.Classes
                .Where(at => at.Playable)
                .ToList();
            
            var matchingArchetypesIdx = matchingArchetypes
                .Select(at => Array.IndexOf(DatabaseAPI.Database.Classes, at))
                .ToList();

            var imgList = new ImageList {ColorDepth = ColorDepth.Depth32Bit, ImageSize = new Size(18, 16)};
            for (var i = 0 ; i < matchingPowersets.Count ; i++)
            {
                var idx = matchingPowersetsIdx[i];
                var icon = new Bitmap(18, 16);
                using (var g = Graphics.FromImage(icon))
                {
                    if (idx < 0)
                    {
                        g.DrawImage(I9Gfx.UnknownPowerset.Bitmap,
                            new Rectangle(0, 0, 16, 16),
                            new Rectangle(0, 0, 16, 16),
                            GraphicsUnit.Pixel);
                    }
                    else
                    {
                        // Weird offset... Icons appear cropped if pasted at (0, 0)
                        g.DrawImage(I9Gfx.Powersets.Bitmap,
                            new Rectangle(2, 0, 18, 16),
                            new Rectangle(idx * 16, 0, 18, 16),
                            GraphicsUnit.Pixel);
                    }

                    imgList.Images.Add(icon);
                }

                powerSetsIconsDict.Add(matchingPowersets[i].FullName, imgIdx);

                imgIdx++;
            }

            var n = matchingArchetypes.Count;
            for (var i = 0; i < n + 1; i++)
            {
                var idx = i < n ? matchingArchetypesIdx[i] : -1;
                var icon = new Bitmap(18, 16);
                using (var g = Graphics.FromImage(icon))
                {
                    if (idx < 0 | i == n)
                    {
                        g.DrawImage(I9Gfx.UnknownArchetype.Bitmap,
                            new Rectangle(0, 0, 16, 16),
                            new Rectangle(0, 0, 16, 16),
                            GraphicsUnit.Pixel);
                    }
                    else
                    {
                        g.DrawImage(I9Gfx.Archetypes.Bitmap,
                            new Rectangle(0, 0, 16, 16),
                            new Rectangle(idx * 16, 0, 16, 16),
                            GraphicsUnit.Pixel);
                    }
                }

                imgList.Images.Add(icon);
                atIconsDict.Add(i == n
                    ? "unknown_generic"
                    : matchingArchetypes[i] == null
                        ? "unknown_generic"
                        : matchingArchetypes[i].ClassName, imgIdx);

                imgIdx++;
            }

            lvPowers.BeginUpdate();
            lvPowers.Items.Clear();
            lvPowers.SmallImageList = imgList;
            var selectedClassIndex = atClass == null ? -1 : Array.IndexOf(DatabaseAPI.Database.Classes, atClass);
            var epicPowersets = DatabaseAPI.GetEpicPowersets(atClass == null ? "" : atClass.ClassName);
            var lvRow = 0;
            foreach (var p in matchingPowers)
            {
                var powerSetData = p.GetPowerSet();
                var powerSetGroup = DatabaseAPI.Database.PowersetGroups[powerSetData.GroupName].Name;
                var allowedClasses = powerSetGroup == "Inherent" | powerSetGroup == "Epic" | powerSetGroup == "Pool"
                    ? new List<string>()
                    : powerSetData.GetArchetypes();
                
                var atClassFull = atClass == null
                    ? allowedClasses.Count > 0
                        ? DatabaseAPI.GetArchetypeByClassName(allowedClasses[0])
                        : null
                    : allowedClasses.Count > 0
                        ? allowedClasses.Contains(atClass.ClassName)
                            ? atClass
                            : DatabaseAPI.GetArchetypeByClassName(allowedClasses[0])
                        : null;

                var allowedForClass = atClass == null || p.AllowedForClass(selectedClassIndex);
                if (!allowedForClass) continue;

                if (atClass != null & powerSetGroup == "Epic" & epicPowersets.Count > 0)
                {
                    if (!epicPowersets.Contains(powerSetData)) continue;
                }

                if (atClassFull != null & atClass != null)
                {
                    if (atClassFull.ClassName != atClass.ClassName) continue;
                    if (atClass.ClassName != "Class_Peacebringer" & IsPeacebringerInherent(p)) continue;
                    if (atClass.ClassName != "Class_Warshade" & IsWarshadeInherent(p)) continue;
                }

                // Show Peacebringer/Warshade AT icon for Dwarves/Novas sub-powers,
                // and other PB/WS inherents
                var overrideAtClass = "";
                if (powerSetGroup == "Inherent")
                {
                    if (IsPeacebringerInherent(p))
                    {
                        overrideAtClass = "Class_Peacebringer";
                    }
                    else if (IsWarshadeInherent(p))
                    {
                        overrideAtClass = "Class_Warshade";
                    }
                }

                var atIconKey = overrideAtClass != ""
                    ? overrideAtClass
                    : atClassFull == null | powerSetGroup == "Epic" | powerSetGroup == "Inherent" | powerSetGroup == "Pool"
                        ? "unknown_generic"
                        : atClassFull.ClassName;

                // Column 0 item text goes into the constructor.
                // Column 1-2 items text go into lvItem.SubItems .
                var lvItem = new ListViewItem(powerSetGroup, atIconsDict[atIconKey]);
                lvItem.SubItems.AddRange(new[] {powerSetData.SetName, p.DisplayName});
                lvPowers.Items.Add(lvItem);

                //lvPowers.AddIconToSubItem(lvRow, 0, atIconsDict[atIconKey]);
                lvPowers.AddIconToSubItem(lvRow, 1, powerSetsIconsDict[powerSetData.FullName]);

                lvRow++;
            }

            lvPowers.ShowSubItemIcons();
            lvPowers.EndUpdate();
        }

        private void ibSelAt_ButtonClicked()
        {
            var selectedArchetype = myParent.GetSelectedArchetype();
            if (selectedArchetype == "")
            {
                cbArchetype.SelectedIndex = 0;

                return;
            }

            var n = cbArchetype.Items.Count;
            for (var i = 1; i < n; i++)
            {
                if (selectedArchetype != cbArchetype.Items[i].ToString()) continue;

                cbArchetype.SelectedIndex = i;

                return;
            }
        }

        private void cbArchetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSet.SelectedItems.Count <= 0) return;

            var sIdx = Convert.ToInt32(lvSet.SelectedItems[0].Tag);
            FillMatchingPowers(sIdx);
        }
    }
}