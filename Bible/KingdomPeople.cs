using System;

namespace Bible
{
    public class KingdomPeople
    {
        public bool HasPossessedAndRealizedTheKingdomOTheHeavens { get; set; }
        public bool BeComfortedBySeeingGodHeavenlyRulingOverTheNegativeSituation { get; set; }
        public bool WillInheritTheEarthInTheComingAge { get; set; }
        public bool BeSatisfiedAndGrantedTheRighteousnessWeSeek { get; set; }

        public void Judge()
        {
            AreOthersJudged = false;
            AreThemselvesJudged = true;
        }

        public bool WillReceiveMercyAndWhatWeDoNotDeserve { get; set; }
        public bool WillSeeGod { get; set; }
        public bool BeCalledTheSonsOfGod { get; set; }
        public bool AreOthersJudged { get; set; }
        public bool AreThemselvesJudged { get; set; }
        public bool HasObjectiveTruthGiven { get; set; }
        public bool HasSubjectiveExperienceGiven { get; set; }

        public void BeEmptiedAndUnloadedInSpirit()
        {
            HasPossessedAndRealizedTheKingdomOTheHeavens = true;
        }

        public void MournOverTheNegativeSituationOfWorldTowardGodEconomy()
        {
            BeComfortedBySeeingGodHeavenlyRulingOverTheNegativeSituation = true;
        }

        public void BeMeekAndWillingToSufferTheWorldOpposition()
        {
            WillInheritTheEarthInTheComingAge = true;
        }

        public void Give(Others others)
        {
            HasObjectiveTruthGiven = false;
            HasSubjectiveExperienceGiven = false;
        }

        public void HungerAndThirstForBeingRightInBehavior()
        {
            BeSatisfiedAndGrantedTheRighteousnessWeSeek = true;
        }

        public void GiveOneWhatHeDoesNotDeserve()
        {
            WillReceiveMercyAndWhatWeDoNotDeserve = true;
        }

        public void HaveSingleGoalOfAccomplishingGodWillForGodGlory()
        {
            WillSeeGod = true;
        }

        public void MakePeaceAmongMenAndExpressFatherLifeAndNatureOfPeace()
        {
            BeCalledTheSonsOfGod = true;
        }

        public void PayAPriceForTheRighteousnessWeSeek()
        {
            HasPossessedAndRealizedTheKingdomOTheHeavens = true;
        }
    }
}
