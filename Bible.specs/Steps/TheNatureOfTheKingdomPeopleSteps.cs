using FluentAssertions;
using TechTalk.SpecFlow;

namespace Bible.Specs.Steps
{
    [Binding]
    public class TheNatureOfTheKingdomPeopleSteps
    {
        private readonly KingdomPeople _KingdomPeople = new KingdomPeople();

        private bool _hasPossessedAndRealizedTheKingdomOTheHeavens;
        private bool _BeComfortedBySeeingGodHeavenlyRulingOverTheNegativeSituation;
        private bool _WillInheritTheEarthInTheComingAge;
        private bool _BeSatisfiedAndGrantedTheRighteousnessWeSeek;
        private bool _WillReceiveMercyAndWhatWeDoNotDeserve;
        private bool _WillSeeGod;
        private bool _BeCalledTheSonsOfGod;

        [When(@"the kingdom people are poor in spirit")]
        public void WhenTheKingdomPeopleArePoorInSpirit()
        {
            _KingdomPeople.BeEmptiedAndUnloadedInSpirit();
            _hasPossessedAndRealizedTheKingdomOTheHeavens = _KingdomPeople.HasPossessedAndRealizedTheKingdomOTheHeavens;
        }

        [Then(@"the kingdom of the heavens is the kingdom people's")]
        public void ThenTheKingdomOfTheHeavensIsTheKingdomPeopleS()
        {
            _hasPossessedAndRealizedTheKingdomOTheHeavens.Should().Be(true);
        }

        [When(@"the kingdom people mourn")]
        public void WhenTheKingdomPeopleMourn()
        {
            _KingdomPeople.MournOverTheNegativeSituationOfWorldTowardGodEconomy();
            _BeComfortedBySeeingGodHeavenlyRulingOverTheNegativeSituation =
                _KingdomPeople.BeComfortedBySeeingGodHeavenlyRulingOverTheNegativeSituation;
        }

        [Then(@"they shall be comforted")]
        public void ThenTheyShallBeComforted()
        {
            _BeComfortedBySeeingGodHeavenlyRulingOverTheNegativeSituation.Should().Be(true);
        }

        [When(@"the kingdom people are the meek")]
        public void WhenTheKingdomPeopleAreTheMeek()
        {
            _KingdomPeople.BeMeekAndWillingToSufferTheWorldOpposition();
            _WillInheritTheEarthInTheComingAge = _KingdomPeople.WillInheritTheEarthInTheComingAge;
        }

        [Then(@"they shall inherit the earth")]
        public void ThenTheyShallInheritTheEarth()
        {
            _WillInheritTheEarthInTheComingAge.Should().Be(true);
        }

        [When(@"the kingdom people hunger and thirst for righteousness")]
        public void WhenTheKingdomPeopleHungerAndThirstForRighteousness()
        {
            _KingdomPeople.HungerAndThirstForBeingRightInBehavior();
            _BeSatisfiedAndGrantedTheRighteousnessWeSeek = _KingdomPeople.BeSatisfiedAndGrantedTheRighteousnessWeSeek;
        }

        [Then(@"they shall be satisfied")]
        public void ThenTheyShallBeSatisfied()
        {
            _BeSatisfiedAndGrantedTheRighteousnessWeSeek.Should().Be(true);
        }

        [When(@"the kingdom people are the merciful")]
        public void WhenTheKingdomPeopleAreTheMerciful()
        {
            _KingdomPeople.GiveOneWhatHeDoesNotDeserve();
            _WillReceiveMercyAndWhatWeDoNotDeserve = _KingdomPeople.WillReceiveMercyAndWhatWeDoNotDeserve;
        }

        [Then(@"they shall be shown mercy")]
        public void ThenTheyShallBeShownMercy()
        {
            _WillReceiveMercyAndWhatWeDoNotDeserve.Should().Be(true);
        }

        [When(@"the kingdom people are the pure in heart")]
        public void WhenTheKingdomPeopleAreThePureInHeart()
        {
            _KingdomPeople.HaveSingleGoalOfAccomplishingGodWillForGodGlory();
            _WillSeeGod = _KingdomPeople.WillSeeGod;
        }

        [Then(@"they shall see God")]
        public void ThenTheyShallSeeGod()
        {
            _WillSeeGod.Should().Be(true);
        }

        [When(@"the kingdom people are the peacemakers")]
        public void WhenTheKingdomPeopleAreThePeacemakers()
        {
            _KingdomPeople.MakePeaceAmongMenAndExpressFatherLifeAndNatureOfPeace();
            _BeCalledTheSonsOfGod = _KingdomPeople.BeCalledTheSonsOfGod;
        }

        [Then(@"they shall be called the sons of God")]
        public void ThenTheyShallBeCalledTheSonsOfGod()
        {
            _BeCalledTheSonsOfGod.Should().Be(true);
        }

        [When(@"the kingdom people are are persecuted for the sake of righteousness")]
        public void WhenTheKingdomPeopleAreArePersecutedForTheSakeOfRighteousness()
        {
            _KingdomPeople.PayAPriceForTheRighteousnessWeSeek();
            _hasPossessedAndRealizedTheKingdomOTheHeavens = _KingdomPeople.HasPossessedAndRealizedTheKingdomOTheHeavens;
        }

    }
}
