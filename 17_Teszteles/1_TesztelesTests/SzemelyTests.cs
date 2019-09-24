using Microsoft.VisualStudio.TestTools.UnitTesting;
using Szemely_osztaly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly.Tests
{
    [TestClass()]
    public class SzemelyTests
    {
        [TestMethod()]
        public void NagyobbETest()
        {
            Szemely egyik = new Szemely();
            Szemely masik = new Szemely();
            egyik.Magassag = 2;
            masik.Magassag = 1.5;
            bool expected = true;
            bool actual = Szemely.NagyobbE(egyik, masik);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void KiirTest()
        {
            Szemely ember = new Szemely();
            string expected = "Abc Zxy";
            string actual = ember.Kiir();
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Szemely ember = new Szemely();
            DateTime szuletett = DateTime.Now;
            string expected = "Név: " + "Abc" + " " + "Zxy" + ", Születési idő: " + szuletett + ", Fizetés: " + 0 + " Ft, Magasság: " + 0 + " m, " + "nem házas";
            string actual = ember.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NevValtoztatasTest()
        {
            Szemely ember = new Szemely();
            ember.Vezeteknev = "ASD";
            ember.Keresztnev = "DSA";
            string expected = "ASD DSA";
            string actual = ember.Kiir(); //Kiir metódust használjuk ellenőrzéshez.
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void NevValtoztatas2Test()
        {
            Szemely ember = new Szemely();
            string expected = "ASD ASD";
            string nevek = "ASD";
            ember.NevValtoztatas2(nevek);
            string actual = ember.Kiir(); //Kiir metódust használjuk ellenőrzéshez.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EgyenloETest()
        {
            DateTime szuletett = DateTime.Now; //DateTime.Now alkalmazása példányosításnál más más adatot adhat meg.
            Szemely egyik = new Szemely();
            Szemely masik = new Szemely();
            egyik.SzuletesIdeje = szuletett;
            masik.SzuletesIdeje = szuletett;
            bool expected = true;
            bool actual = Szemely.EgyenloE(egyik, masik);
            Assert.AreEqual(expected, actual);
        }
    }
}