using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalcualateReduction(time);
            return CalculateOverallScore(score, reduction);

        }

        public abstract int CalculateBaseScore(int hits);
        public abstract int CalcualateReduction(TimeSpan time);
        public abstract int CalculateOverallScore(int score, int reduction);
    }

    public class MensScoringAlgoritm : ScoringAlgorithm
    {

        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalcualateReduction(TimeSpan time)
        {
            return ((int)time.TotalSeconds / 5);
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }
    }

    class WomensScoringAlgorithm : ScoringAlgorithm
    {

        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalcualateReduction(TimeSpan time)
        {
            return ((int)time.TotalSeconds / 4);
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }
    }
}
