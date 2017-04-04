using System;
using TechTalk.SpecFlow;

namespace GRM.Specs
{
    [Binding]
    public class AvailableProductsSteps
    {
        [Given(@"the supplied above reference data")]
        public void GivenTheSuppliedAboveReferenceData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user enters ITunes (.*)st March (.*)")]
        public void WhenUserEntersITunesStMarch(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the output is : Artist\|Title\|Usage\|StartDate\|EndDatenMonkey Claw\|Black Mountain\|digital download\|(.*)st Feb (.*)\|\nMonkey Claw\|Motor Mouth\|digital download\|(.*)st Mar (.*)\|\nTinie Tempah\|Frisky \(Live from SoHo\)\|digital download\|(.*)st Feb (.*)\|\nTinie Tempah\|Miami (.*) Ibiza\|digital download\|(.*)st Feb (.*)\|")]
        public void ThenTheOutputIsArtistTitleUsageStartDateEndDatenMonkeyClawBlackMountainDigitalDownloadStFeb_MonkeyClawMotorMouthDigitalDownloadStMar_TinieTempahFriskyLiveFromSoHoDigitalDownloadStFeb_TinieTempahMiamiIbizaDigitalDownloadStFeb(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
