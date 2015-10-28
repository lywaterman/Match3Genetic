using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeneticSharp.Domain;
using GeneticSharp.Domain.Fitnesses;
using GeneticSharp.Domain.Chromosomes;

namespace Match3Genetic
{
    public class Match3Fitness: IFitness
    {
        public double Evaluate(IChromosome chromosome)
        {
            return 0.0f;
        }
    }

    public class Match3Chromosome : ChromosomeBase
    {
        public Match3Chromosome(): base(10)
        {

        }

        public override Gene GenerateGene(int geneIndex)
        {
            throw new NotImplementedException();
        }

        public override IChromosome CreateNew()
        {
            throw new NotImplementedException();
        }
    }
}
