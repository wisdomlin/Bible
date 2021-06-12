using TechTalk.SpecFlow;
using FluentAssertions;

namespace Bible.Specs.Steps
{
    [Binding]
    public class ThePrinciplesOfDealingWithOthersSteps
    {
        private readonly KingdomPeople _KingdomPeople = new KingdomPeople();
        private readonly Others _Others = new Others();
        private bool _AreOthersJudged;
        private bool _AreThemselvesJudged;
        private bool _HasObjectiveTruthGiven;
        private bool _HasSubjectiveExperienceGiven;

        [When(@"the kingdom people judge")]
        public void WhenTheKingdomPeopleJudge()
        {
            _KingdomPeople.Judge();
            _AreOthersJudged = _KingdomPeople.AreOthersJudged;
            _AreThemselvesJudged = _KingdomPeople.AreThemselvesJudged;
        }
        
        [Then(@"the kingdom people always judge themselves")]
        public void ThenTheKingdomPeopleAlwaysJudgeThemselves()
        {
            _AreOthersJudged.Should().Be(false);
            _AreThemselvesJudged.Should().Be(true);
        }

        [Given(@"others capture, destruct, and corrupt")]
        public void GivenOthersCaptureDestructAndCorrupt()
        {
            _Others.DoCaptureDestructAndCorrupt = true;
        }

        [When(@"the kingdom people give")]
        public void WhenTheKingdomPeopleGive()
        {
            _KingdomPeople.Give(_Others);
            _HasObjectiveTruthGiven = _KingdomPeople.HasObjectiveTruthGiven;
            _HasSubjectiveExperienceGiven = _KingdomPeople.HasSubjectiveExperienceGiven;
        }


        [Then(@"the kingdom people do not give the objective truth, nor the subjective experiences")]
        public void ThenTheKingdomPeopleDoNotGiveTheObjectiveTruthNorTheSubjectiveExperiences()
        {
            _HasObjectiveTruthGiven.Should().Be(false);
            _HasSubjectiveExperienceGiven.Should().Be(false);
        }

    }
}
