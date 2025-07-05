using System;
using Verse;

namespace JPTools
{
    public static class Utility
    {
        //Retrieves a Def's label while avoiding incomplete ones by falling back to the defName. It's a Function and not a Method so it can be used in LINQ queries. 
        public static Func<Def, string> DefLabelFailSafe = (a) => a.label ?? a.defName ?? "Unlabeled";
    }
}
