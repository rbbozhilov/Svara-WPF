using Svara.WPF.Models.Cards;
using Svara.WPF.Services;
using System.Collections.Generic;
using Xunit;

namespace Svara.Tests.Score
{
    public class ScoreServiceSpecs
    {
        private ScoreService scoreService;
        private AsoPika asoPika;
        private AsoKaro asoKaro;
        private AsoKupa asoKupa;
        private AsoSpatia asoSpatia;
        private SevenKaro sevenKaro;
        private SevenSpatia sevenSpatia;
        private SevenPika sevenPika;
        private SevenKupa sevenKupa;
        private EightKaro eightKaro;
        private EightPika eightPika;
        private EightSpatia eightSpatia;
        private EightKupa eightKupa;
        private NineSpatia nineSpatia;
        private NinePika ninePika;
        private NineKaro nineKaro;
        private NineKupa nineKupa;
        private TenSpatia tenSpatia;
        private TenKaro tenKaro;
        private TenPika tenPika;
        private TenKupa tenKupa;
        private PopPika popPika;
        private PopKupa popKupa;
        private PopSpatia popSpatia;
        private PopKaro popKaro;
        private DamaPika damaPika;
        private DamaKaro damaKaro;
        private DamaKupa damaKupa;
        private DamaSpatia damaSpatia;


        public ScoreServiceSpecs()
        {
            this.asoPika = new AsoPika();
            this.asoKupa = new AsoKupa();
            this.asoSpatia = new AsoSpatia();
            this.asoKaro = new AsoKaro();
            this.sevenKaro = new SevenKaro();
            this.sevenPika = new SevenPika();
            this.sevenKupa = new SevenKupa();
            this.sevenSpatia = new SevenSpatia();
            this.eightKaro = new EightKaro();
            this.eightSpatia = new EightSpatia();
            this.eightPika = new EightPika();
            this.eightKupa = new EightKupa();
            this.nineKaro = new NineKaro();
            this.ninePika = new NinePika();
            this.nineKupa = new NineKupa();
            this.nineSpatia = new NineSpatia();
            this.tenKaro = new TenKaro();
            this.tenKupa = new TenKupa();
            this.tenSpatia = new TenSpatia();
            this.tenPika = new TenPika();
            this.damaKaro = new DamaKaro();
            this.damaSpatia = new DamaSpatia();
            this.damaPika = new DamaPika();
            this.damaKupa = new DamaKupa();
            this.popKaro = new PopKaro();
            this.popSpatia = new PopSpatia();
            this.popKupa = new PopKupa();
            this.popPika = new PopPika();


        }

        [Fact]
        public void CheckThreeAso()
        => this.MakeTest(this.asoKaro, this.asoKupa, this.asoSpatia, 33);

        [Fact]
        public void CheckThoAso()
        => this.MakeTest(this.asoKaro, this.asoKupa, this.tenPika, 22);

        [Fact]
        public void CheckThoAso_Two()
        => this.MakeTest(this.popPika, this.asoKupa, this.asoKaro, 22);

        [Fact]
        public void CheckThreeAso_Two()
        => this.MakeTest(this.asoKaro, this.asoPika, this.asoSpatia, 33);

        [Fact]
        public void CheckThreeAso_three()
        => this.MakeTest(this.asoKaro, this.asoPika, this.asoKupa, 33);

        [Fact]
        public void CheckThreeTen()
        => this.MakeTest(this.tenKaro, this.tenKupa, this.tenSpatia, 30);

        [Fact]
        public void CheckThreeTen_Two()
        => this.MakeTest(this.tenKaro, this.tenPika, this.tenSpatia, 30);

        [Fact]
        public void CheckThreeTen_three()
        => this.MakeTest(this.tenKaro, this.tenPika, this.tenKupa, 30);

        [Fact]
        public void CheckThreeSeven()
        => this.MakeTest(this.sevenKaro, this.sevenPika, this.sevenKupa, 30);

        [Fact]
        public void CheckThreeSeven_Two()
        => this.MakeTest(this.sevenKaro, this.sevenSpatia, this.sevenKupa, 34);

        [Fact]
        public void CheckSevenDouble_Combination()
        => this.MakeTest(this.sevenKaro, this.sevenKupa, this.nineKaro, 23);

        [Fact]
        public void CheckSevenDouble_CombinationTwo()
        => this.MakeTest(this.sevenKaro, this.sevenKupa, this.tenSpatia, 23);

        [Fact]
        public void CheckSevenSpatia_Combination()
        => this.MakeTest(this.sevenSpatia, this.tenKupa, this.popKupa, 31);

        [Fact]
        public void CheckSevenSpatia_CombinationTwo()
        => this.MakeTest(this.sevenSpatia, this.asoPika, this.ninePika, 31);

        [Fact]
        public void CheckSevenSpatia_CombinationThree()
        => this.MakeTest(this.sevenSpatia, this.sevenKaro, this.tenKaro, 28);

        [Fact]
        public void CheckSevenSpatia_AndSameTwoCards()
        => this.MakeTest(this.sevenSpatia, this.tenKaro, this.tenPika, 31);

        [Fact]
        public void CheckSevenSpatia_AndSameTwoCards_Two()
        => this.MakeTest(this.sevenSpatia, this.nineKaro, this.nineKupa, 29);

        [Fact]
        public void CheckSameTypes()
        => this.MakeTest(this.eightKaro, this.tenKaro, this.asoKaro, 29);

        [Fact]
        public void CheckTwoSameTypes_One()
        => this.MakeTest(this.eightKaro, this.tenKaro, this.asoPika, 18);

        [Fact]
        public void CheckTwoSameTypes_Two()
        => this.MakeTest(this.eightKaro, this.tenPika, this.asoKaro, 19);

        [Fact]
        public void CheckTwoSameTypes_Three()
        => this.MakeTest(this.tenPika, this.eightKaro, this.damaKaro, 18);

        [Fact]
        public void CheckDifferentTypes()
        => this.MakeTest(this.tenPika, this.eightKaro, this.popKupa, 10);

        [Fact]
        public void CheckDifferentTypes_Two()
        => this.MakeTest(this.asoPika, this.eightKaro, this.popKupa, 11);

        [Fact]
        public void CheckDifferentTypes_Three()
        => this.MakeTest(this.tenKaro, this.asoPika, this.eightKupa, 11);

        [Fact]
        public void CheckDifferentTypes_Four()
        => this.MakeTest(this.eightPika, this.eightKupa, this.nineKaro, 9);

        [Fact]
        public void CheckTwoTypesSameSevenSpatia_One()
        => this.MakeTest(this.sevenSpatia, this.asoKaro, this.tenKupa, 22);

        [Fact]
        public void CheckTwoTypesSameSevenSpatia_Two()
        => this.MakeTest(this.nineKaro, this.sevenSpatia, this.eightKupa, 20);

        [Fact]
        public void CheckTwoTypesSameSevenSpatia_Three()
        => this.MakeTest(this.tenSpatia, this.sevenSpatia, this.asoPika, 22);

        [Fact]
        public void CheckTwoTypesSameSevenSpatia_Four()
        => this.MakeTest(this.sevenSpatia, this.nineKaro, this.asoSpatia, 22);

        [Fact]
        public void CheckTwoTypesSameSevenSpatia_Five()
        => this.MakeTest(this.sevenSpatia, this.tenSpatia, this.asoPika, 22);

        [Fact]
        public void CheckTwoTypesSameSevenSpatia_Six()
        => this.MakeTest(this.nineKaro, this.eightKupa, this.sevenSpatia, 20);

        [Fact]
        public void CheckTwoTypesSameSevenSpatia_Seven()
        => this.MakeTest(this.asoPika, this.sevenKaro, this.sevenSpatia, 23);

        private void MakeTest(BaseCard firstCard, BaseCard secondCard, BaseCard thirdCard, int expectedResult)
        {
            //Arrange
            List<BaseCard> cards = new List<BaseCard>();
            cards.Add(firstCard);
            cards.Add(secondCard);
            cards.Add(thirdCard);

            //Act
            this.scoreService = new ScoreService(cards);
            int actualResult = this.scoreService.MakeScore();

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
