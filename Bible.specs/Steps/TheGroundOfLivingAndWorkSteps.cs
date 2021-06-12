
using TechTalk.SpecFlow;
using FluentAssertions;

namespace Bible.Specs.Steps
{
    [Binding]
    public class TheGroundOfLivingAndWorkSteps
    {
        private readonly KingdomPeople _KingdomPeople = new KingdomPeople();
        private string _InwardMotive;
        private string _Foundation;

        [When(@"the kingdom people Live And Work")]
        public void WhenTheKingdomPeopleLiveAndWork()
        {
            _KingdomPeople.LiveAndWork();
            _InwardMotive = _KingdomPeople.InwardMotive;
            _Foundation = _KingdomPeople.Foundation;
        }
        
        [Then(@"inward motive is not the old man")]
        public void ThenInwardMotiveIsNotTheOldMan()
        {
            _InwardMotive.Should().NotBe("TheOldMan");
        }
        
        [Then(@"inward motive is not the self")]
        public void ThenInwardMotiveIsNotTheSelf()
        {
            _InwardMotive.Should().NotBe("TheSelf");
        }
        
        [Then(@"inward motive is not the flesh")]
        public void ThenInwardMotiveIsNotTheFlesh()
        {
            _InwardMotive.Should().NotBe("TheFlesh");
        }
        
        [Then(@"inward motive is not the human concept")]
        public void ThenInwardMotiveIsNotTheHumanConcept()
        {
            _InwardMotive.Should().NotBe("TheHumanConcept");
        }
        
        [Then(@"inward motive is not the world with its glory")]
        public void ThenInwardMotiveIsNotTheWorldWithItsGlory()
        {
            _InwardMotive.Should().NotBe("TheWorldWithItsGlory");
        }
        
        [Then(@"inward motive is God's will")]
        public void ThenInwardMotiveIsGodSWill()
        {
            _InwardMotive.Should().Be("GodSWill");
        }

        [Then(@"foundation is God's will")]
        public void ThenFoundationIsGodSWill()
        {
            _Foundation.Should().Be("GodSWill");
        }

        [Then(@"foundation is not the human concept")]
        public void ThenFoundationIsNotTheHumanConcept()
        {
            _InwardMotive.Should().NotBe("TheHumanConcept");
        }

        [Then(@"foundation is not the natural ways")]
        public void ThenFoundationIsNotTheNaturalWays()
        {
            _InwardMotive.Should().NotBe("TheNaturalWays");
        }

    }
}
