using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace mrbBase.Base.Master_Classes
{
    public static class Utilities
    {
        public static string FixDP(float iNum)
        {
            return iNum < 100.0 && iNum > -100.0 ? FixDP(iNum, 2) : FixDP(iNum, 1);
        }

        public static string FixDP(float iNum, int maxDecimal)
        {
            var format = "0.";
            if (iNum >= 10.0 || iNum <= -10.0)
                format = "###0.";
            for (var index = 0; index < maxDecimal; ++index)
                format += "#";
            return iNum.ToString(format);
        }

        public static TV ProperEnum<T, TV>(dynamic value) where TV : struct
        {
            var converted = Enum.TryParse<TV>(Enum.GetName(typeof(T), (T)value), out var result);
            return converted ? result : new TV();
        }

        public static string CompactEffectString(string effectString, int collection)
        {
            ModifiedEffectString(ref effectString, collection);

            return effectString;
        }

        public static void ModifiedEffectString(ref string effectString, int collection)
        {
            var matchCollections = new Dictionary<string, string>[]
            {
                new()
                {
                    { @"(DamageBuff\(Smashing\), \d.*% DamageBuff\(Lethal\), \d.*% DamageBuff\(Fire\), \d.*% DamageBuff\(Cold\), \d.*% DamageBuff\(Energy\), \d.*% DamageBuff\(Negative\), \d.*% DamageBuff\(Toxic\), \d.*% DamageBuff\(Psionic\))", @"DamageBuff(All)" },
                    { @"(Defense\(Melee\), \d.*% Defense\(AoE\), \d.*% Defense\(Ranged\), \d.*% Defense\(Smashing\), \d.*% Defense\(Lethal\), \d.*% Defense\(Fire\), \d.*% Defense\(Cold\), \d.*% Defense\(Energy\), \d.*% Defense\(Negative\), \d.*% Defense\(Psionic\))", @"Defense(All)" },
                    { @"(Def\(Melee\), \d.*% Def\(AoE\), \d.*% Def\(Rngd\), \d.*% Def\(Smash\), \d.*% Def\(Lethal\), \d.*% Def\(Fire\), \d.*% Def\(Cold\), \d.*% Def\(Energy\), \d.*% Def\(Neg\), \d.*% Def\(Psi\))", @"Defense(All)" },
                    { @"(Resistance\((Smashing|Lethal)\), \d.*% Resistance\((Smashing|Lethal)\), \d.*% Resistance\(Fire\), \d.*% Resistance\(Cold\), \d.*% Resistance\(Energy\), \d.*% Resistance\(Negative\), \d.*% Resistance\((Psionic|Toxic)\), \d.*% Resistance\((Toxic|Psionic)\)|Resistance\(Smashing,Fire,Cold,Energy,Negative,Toxic,Psionic\).*Resistance\(Lethal\))", @"Resistance(All)" },
                    { @"(Res\((Smashing|Lethal)\), \d.*% Res\((Smashing|Lethal)\), \d.*% Res\(Fire\), \d.*% Res\(Cold\), \d.*% Res\(Energy\), \d.*% Res\(Negative\), \d.*% Res\((Psionic|Toxic)\), \d.*% Res\((Toxic|Psionic)\)|Res\(Smashing,Fire,Cold,Energy,Negative,Toxic,Psionic\).*Res\(Lethal\))", @"Resistance(All)" },
                    { @"(MezResist\(Immobilized\).*MezResist\(Held\).*MezResist\(Stunned\).*MezResist\(Sleep\).*MezResist\(Terrorized\).*MezResist\(Confused\))", @"MezResist(All)" },
                    { @"(MezRes\(Immobilized\).*MezRes\(Held\).*MezRes\(Stunned\).*MezRes\(Sleep\).*MezRes\(Terrorized\).*MezRes\(Confused\))", @"MezResist(All)" },
                    { @"(SpeedJumping.*JumpHeight.*SpeedFlying.*SpeedRunning)", @"Movement Speed" },
                    { @"(Knockback.*\(Mag.-)", @"Knockback Protection (Mag " },
                    { @"(Knockback.*Knockup.*protection)", @"Knockback Protection"}
                },

                new()
                {
                    { @"(DamageBuff\(Smashing\), \d.*% DamageBuff\(Lethal\), \d.*% DamageBuff\(Fire\), \d.*% DamageBuff\(Cold\), \d.*% DamageBuff\(Energy\), \d.*% DamageBuff\(Negative\), \d.*% DamageBuff\(Toxic\), \d.*% DamageBuff\(Psionic\))", @"DamageBuff(All)" },
                    { @"(Defense\(Melee\), \d.*% Defense\(AoE\), \d.*% Defense\(Ranged\), \d.*% Defense\(Smashing\), \d.*% Defense\(Lethal\), \d.*% Defense\(Fire\), \d.*% Defense\(Cold\), \d.*% Defense\(Energy\), \d.*% Defense\(Negative\), \d.*% Defense\(Psionic\))", @"Defense(All)" },
                    { @"(Def\(Melee\), \d.*% Def\(AoE\), \d.*% Def\(Rngd\), \d.*% Def\(Smash\), \d.*% Def\(Lethal\), \d.*% Def\(Fire\), \d.*% Def\(Cold\), \d.*% Def\(Energy\), \d.*% Def\(Neg\), \d.*% Def\(Psi\))", @"Defense(All)" },
                    { @"(Resistance\((Smashing|Lethal)\), \d.*% Resistance\((Smashing|Lethal)\), \d.*% Resistance\(Fire\), \d.*% Resistance\(Cold\), \d.*% Resistance\(Energy\), \d.*% Resistance\(Negative\), \d.*% Resistance\((Psionic|Toxic)\), \d.*% Resistance\((Toxic|Psionic)\)|Resistance\(Smashing,Fire,Cold,Energy,Negative,Toxic,Psionic\).*Resistance\(Lethal\))", @" Resistance(All)" },
                    { @"(Res\((Smashing|Lethal)\), \d.*% Res\((Smashing|Lethal)\), \d.*% Res\(Fire\), \d.*% Res\(Cold\), \d.*% Res\(Energy\), \d.*% Res\(Negative\), \d.*% Res\((Psionic|Toxic)\), \d.*% Res\((Toxic|Psionic)\)|Res\(Smashing,Fire,Cold,Energy,Negative,Toxic,Psionic\).*Res\(Lethal\))", @"Resistance(All)" },
                    { @"(MezResist\(Immobilized\).*MezResist\(Held\).*MezResist\(Stunned\).*MezResist\(Sleep\).*MezResist\(Terrorized\).*MezResist\(Confused\))", @"Status Resistance" },
                    { @"(MezRes\(Immobilized\).*MezRes\(Held\).*MezRes\(Stunned\).*MezRes\(Sleep\).*MezRes\(Terrorized\).*MezRes\(Confused\))", @"Status Resistance" },
                    { @"(SpeedJumping.*JumpHeight.*SpeedFlying.*SpeedRunning)", @"Movement Speed" },
                    { @"(Knockback.*\(Mag.-)", @"Knockback Protection (Mag " },
                    { @"(Knockback.*Knockup.*protection)", @"Knockback Protection"}
                },

                new()
                {
                    { @"(DamageBuff\(Smashing, Lethal, Fire, Cold, Energy, Negative, Toxic, Psionic\))", @"DamageBuff(All)" },
                    { @"(Defense\(Melee, AoE, Ranged, Smashing, Lethal, Fire, Cold, Energy, Negative, Psionic\))", @"Defense(All)" },
                    { @"(Defense\(Melee, AoE, Ranged\))", @"Defense(All positions)" },
                    { @"(Defense\(Smashing, Lethal, Fire, Cold, Energy, Negative, Psionic\))", @"Defense(All elements)" },
                    { @"(Resistance\((Smashing|Lethal), (Smashing|Lethal), Fire, Cold, Energy, Negative, (Psionic|Toxic), (Toxic|Psionic)\))", @"Resistance(All)" },
                    { @"(MezResist\((Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused)\))", @"Status Resistance" },
                    { @"(Mez\((Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused), (Immobilized|Held|Stunned|Sleep|Terrorized|Confused)\))", @"Status Protection" },
                    { @"(SpeedJumping.*JumpHeight.*SpeedFlying.*SpeedRunning)", @"Movement Speed" }/*,
                    { @"(Knockback.*\(Mag.-)", @"Knockback Protection (Mag " },
                    { @"(Knockback.*Knockup.*protection)", @"Knockback Protection"}*/
                }
            };

            if (collection < 1 || collection > matchCollections.Length)
            {
                return;
            }

            effectString = matchCollections[collection - 1].Aggregate(effectString, (current, regMatch) => Regex.Replace(current, regMatch.Key, regMatch.Value));
        }
    }
}