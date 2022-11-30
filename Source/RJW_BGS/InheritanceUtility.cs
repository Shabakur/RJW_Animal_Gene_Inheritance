using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace RJW_BGS
{
    public class InheritanceUtility
    {
        public static List<GeneDef> AnimalInheritedGenes(Pawn father, Pawn mother)
        {
            List<GeneDef> genelist = new List<GeneDef>();
            if (father != null && !father.RaceProps.Humanlike)
            {
                PawnKindDef pawnKindDef = father.kindDef;
                RaceGeneDef raceGeneDef = RJWcopy.GetRaceGenDefInternal(pawnKindDef);
                if (raceGeneDef != null)
                {
                    GeneDef gene = null;
                    //In case you hit a modded gene not currently active try again.
                    for (int i = 0; i < 50 || gene == null; i++)
                    {
                        if (raceGeneDef.genes.Any())
                        {
                          gene = DefDatabase<GeneDef>.GetNamed(raceGeneDef.genes.RandomElement());
                        }
                    }
                    if (gene != null)
                    {
                        genelist.Add(gene);
                    }
                }
            }

            if (mother != null && !mother.RaceProps.Humanlike)
            {
                PawnKindDef pawnKindDef = mother.kindDef;
                RaceGeneDef raceGeneDef = RJWcopy.GetRaceGenDefInternal(pawnKindDef);
                if (raceGeneDef != null)
                {
                    GeneDef gene = null;
                    //In case you hit a modded gene not currently active try again.
                    for (int i = 0; i < 50 || gene == null; i++)
                    {
                        if (raceGeneDef.genes.Any())
                        {
                            gene = DefDatabase<GeneDef>.GetNamed(raceGeneDef.genes.RandomElement());
                        }
                    }
                    if (gene != null)
                    {
                        genelist.Add(gene);

                    }
                    
                }
            }
            return genelist;
        }
    }
}
