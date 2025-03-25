using Mediatheque.Core.Model;
using Mediatheque.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.CoreTests.ServiceTests.MediathequeServiceTests
{
    [TestClass]
    public class PresenterJeuxShould
    {
        [TestMethod]
        public void ReturnNoGames_WhenFondDeCommerceVide()
        {
            //Arrange
            MediathequeService mediathequeService = new MediathequeService(null);

            //Act
            string actual = mediathequeService.PresenterJeux();

            //Assert
            Assert.AreEqual("Pas de jeux", actual);
        }

        [TestMethod]
        public void ReturnNoGames_WhenFondDeCommerceContientJusteCD()
        {
            //Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new CD("Hello Kitty", "DSK"));
            mediathequeService.AddObjet(new CD("My Little Pony", "PNL"));

            //Act
            string actual = mediathequeService.PresenterJeux();

            //Assert
            Assert.AreEqual("Pas de jeux", actual);
        }

        [TestMethod]
        public void Return2AtTheBegining_WhenFondDeCommerceContient2Game()
        {
            //Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
           mediathequeService.AddObjet(new JeuxDeSociete("Jeux de 54 cartes", 3,99,"carrefour", TypeJeuxDeSociete.Carte));
           mediathequeService.AddObjet(new JeuxDeSociete("Risk", 13,99,"Auchan", TypeJeuxDeSociete.Plateau));

            //Act
            string actual = mediathequeService.PresenterJeux();

            //Assert
            Assert.AreEqual("2", actual.Substring(0,1));
        }

        [TestMethod]
        public void Return1AtTheBeggining_WhenFondDeCommerceContient1GameAnd1CD()
        {
            //Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
           mediathequeService.AddObjet(new JeuxDeSociete("Jeux de 54 cartes", 3,99,"carrefour", TypeJeuxDeSociete.Carte));
           mediathequeService.AddObjet(new CD("My Little Pony", "PNL"));

            //Act
            string actual = mediathequeService.PresenterJeux();

            //Assert
            Assert.AreEqual("1", actual.Substring(0,1));
        }

        [TestMethod]
        public void ReturnEditorAndTitle_WhenFondDeCommerceContient1Game()
        {
            //Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
           mediathequeService.AddObjet(new JeuxDeSociete("Jeux de 54 cartes", 3,99,"carrefour", TypeJeuxDeSociete.Carte));

            //Act
            string actual = mediathequeService.PresenterJeux();

            //Assert
            Assert.AreEqual(true, actual.Contains("carrefour"));
            Assert.AreEqual(true, actual.Contains("Jeux de 54 cartes"));
        }

    }
}
