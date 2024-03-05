using Classses;

namespace BilbasenKonsol
{
        internal class Program
        {
            public static void Main(string[] args)
            {
                List<Car> cars = new List<Car>();
                Car fordMustang1963 = new Car("Ford", "Mustang", 1963, "Red", 430);
                Car toyotaCamry2020 = new Car("Toyota", "Camry", 2020, "Blue", 200);
                Car chevyCorvette2022 = new Car("Chevrolet", "Corvette", 2022, "Silver", 650);
                Car hondaCivic2008 = new Car("Honda", "Civic", 2008, "Black", 140);
                Car bmwM32017 = new Car("BMW", "M3", 2017, "White", 425);
                Car volkswagenBeetle2010 = new Car("Volkswagen", "Beetle", 2010, "Yellow", 150);
                Car teslaModelS2021 = new Car("Tesla", "Model S", 2021, "Gray", 670);
                Car mercedesCClass2019 = new Car("Mercedes-Benz", "C-Class", 2019, "Silver", 255);
                Car fordFocus2015 = new Car("Ford", "Focus", 2015, "Red", 160);
                Car toyotaPrius2012 = new Car("Toyota", "Prius", 2012, "Green", 134);
                Car chevroletImpala2016 = new Car("Chevrolet", "Impala", 2016, "Blue", 197);
                Car audiA42018 = new Car("Audi", "A4", 2018, "Black", 252);
                Car subaruOutback2014 = new Car("Subaru", "Outback", 2014, "Silver", 175);
                Car nissanAltima2017 = new Car("Nissan", "Altima", 2017, "White", 179);
                Car hyundaiElantra2013 = new Car("Hyundai", "Elantra", 2013, "Red", 148);
                Car lexusRX3502016 = new Car("Lexus", "RX 350", 2016, "Blue", 295);
                Car kiaSoul2011 = new Car("Kia", "Soul", 2011, "Green", 130);
                Car mazdaCX52020 = new Car("Mazda", "CX-5", 2020, "Silver", 187);
                Car jaguarXF2015 = new Car("Jaguar", "XF", 2015, "Black", 340);
                Car porsche9112019 = new Car("Porsche", "911", 2019, "Red", 443);
                Car buickEnclave2018 = new Car("Buick", "Enclave", 2018, "White", 310);
                Car infinitiQ502013 = new Car("Infiniti", "Q50", 2013, "Gray", 328);
                Car volvoXC902017 = new Car("Volvo", "XC90", 2017, "Blue", 316);
                Car fiat5002014 = new Car("Fiat", "500", 2014, "Red", 135);
                Car lincolnNavigator2016 = new Car("Lincoln", "Navigator", 2016, "Black", 450);
                Car landRoverDiscovery2022 = new Car("Land Rover", "Discovery", 2022, "Green", 335);
                Car jeepWrangler2019 = new Car("Jeep", "Wrangler", 2019, "Gray", 285);
                Car dodgeCharger2015 = new Car("Dodge", "Charger", 2015, "Blue", 370);
                Car gmcYukon2017 = new Car("GMC", "Yukon", 2017, "White", 355);
                Car teslaModel32022 = new Car("Tesla", "Model 3", 2022, "Red", 440);
                Car cadillacEscalade2014 = new Car("Cadillac", "Escalade", 2014, "Black", 420);
                Car astonMartinDB112011 = new Car("Aston Martin", "DB11", 2011, "Silver", 600);
                Car subaruForester2018 = new Car("Subaru", "Forester", 2018, "Blue", 182);
                Car genesisG802016 = new Car("Genesis", "G80", 2016, "White", 311);
                Car buickRegal2020 = new Car("Buick", "Regal", 2020, "Black", 250);
                Car miniCooper2013 = new Car("Mini", "Cooper", 2013, "Green", 181);
                Car audiQ72020 = new Car("Audi", "Q7", 2020, "Gray", 335);
                Car lexusIS2502015 = new Car("Lexus", "IS 250", 2015, "Silver", 204);
                Car volkswagenJetta2017 = new Car("Volkswagen", "Jetta", 2017, "Red", 150);
                Car bmwX52019 = new Car("BMW", "X5", 2019, "Blue", 335);
                Car landRoverRangeRover2021 = new Car("Land Rover", "Range Rover", 2021, "White", 400);
                Car toyotaHighlander2012 = new Car("Toyota", "Highlander", 2012, "Black", 270);
                Car mercedesGLEClass2014 = new Car("Mercedes-Benz", "GLE-Class", 2014, "Silver", 302);
                Car nissanRogue2020 = new Car("Nissan", "Rogue", 2020, "Green", 170);
                Car fordExplorer2016 = new Car("Ford", "Explorer", 2016, "Gray", 290);
                Car hondaAccord2010 = new Car("Honda", "Accord", 2010, "Blue", 190);
                Car chevroletTahoe2018 = new Car("Chevrolet", "Tahoe", 2018, "Black", 355);
                Car audiA62015 = new Car("Audi", "A6", 2015, "White", 310);
                Car kiaOptima2017 = new Car("Kia", "Optima", 2017, "Red", 185);
                Car jaguarXJ2020 = new Car("Jaguar", "XJ", 2020, "Silver", 340);
                Car subaruLegacy2019 = new Car("Subaru", "Legacy", 2019, "Blue", 182);
                Car porscheCayenne2014 = new Car("Porsche", "Cayenne", 2014, "Black", 300);
                Car teslaModelX2016 = new Car("Tesla", "Model X", 2016, "Gray", 518);
                Car lexusGX4602020 = new Car("Lexus", "GX 460", 2020, "White", 301);
                Car lincolnContinental2017 = new Car("Lincoln", "Continental", 2017, "Black", 400);
                Car infinitiQX602013 = new Car("Infiniti", "QX60", 2013, "Red", 295);
                Car volvoS602017 = new Car("Volvo", "S60", 2017, "Blue", 250);
                Car fiatSpider2018 = new Car("Fiat", "Spider", 2018, "Yellow", 160);
                Car landRoverDefender2021 = new Car("Land Rover", "Defender", 2021, "Green", 296);
                Car jeepGrandCherokee2015 = new Car("Jeep", "Grand Cherokee", 2015, "White", 360);
                Car dodgeDurango2019 = new Car("Dodge", "Durango", 2019, "Black", 293);
                Car gmcTerrain2012 = new Car("GMC", "Terrain", 2012, "Silver", 182);
                Car teslaModelY2023 = new Car("Tesla", "Model Y", 2023, "Red", 450);
                Car cadillacCT62014 = new Car("Cadillac", "CT6", 2014, "Blue", 404);
                Car astonMartinVantage2010 = new Car("Aston Martin", "Vantage", 2010, "Black", 420);
                Car subaruCrosstrek2016 = new Car("Subaru", "Crosstrek", 2016, "Orange", 152);
                Car genesisG902019 = new Car("Genesis", "G90", 2019, "White", 365);
                Car buickEncore2015 = new Car("Buick", "Encore", 2015, "Silver", 138);
                Car miniCountryman2017 = new Car("Mini", "Countryman", 2017, "Green", 134);
                Car audiTT2013 = new Car("Audi", "TT", 2013, "Red", 220);
                Car lexusLC5002021 = new Car("Lexus", "LC 500", 2021, "Blue", 471);
                Car volkswagenPassat2018 = new Car("Volkswagen", "Passat", 2018, "Black", 174);
                Car bmwX32016 = new Car("BMW", "X3", 2016, "Gray", 248);
                Car landRoverVelar2019 = new Car("Land Rover", "Velar", 2019, "White", 380);
                Car toyotaRav42015 = new Car("Toyota", "RAV4", 2015, "Blue", 203);
                Car mercedesGLC3002020 = new Car("Mercedes-Benz", "GLC 300", 2020, "Silver", 255);
                Car nissanSentra2011 = new Car("Nissan", "Sentra", 2011, "Red", 130);
                Car fordEscape2014 = new Car("Ford", "Escape", 2014, "Green", 168);
                Car hondaCRV2018 = new Car("Honda", "CR-V", 2018, "White", 190);
                Car chevroletMalibu2016 = new Car("Chevrolet", "Malibu", 2016, "Black", 160);
                Car audiA32014 = new Car("Audi", "A3", 2014, "Gray", 170);
                Car kiaForte2017 = new Car("Kia", "Forte", 2017, "Red", 147);
                Car jaguarFType2022 = new Car("Jaguar", "F-Type", 2022, "Blue", 450);
                Car subaruWRX2015 = new Car("Subaru", "WRX", 2015, "Silver", 268);
                Car porschePanamera2017 = new Car("Porsche", "Panamera", 2017, "White", 330);
                Car teslaRoadster2022 = new Car("Tesla", "Roadster", 2022, "Red", 1000);
                Car lexusLS4602014 = new Car("Lexus", "LS 460", 2014, "Black", 386);
                Car lincolnMKC2016 = new Car("Lincoln", "MKC", 2016, "Silver", 240);
                Car infinitiQ602017 = new Car("Infiniti", "Q60", 2017, "Blue", 300);
                Car volvoV602013 = new Car("Volvo", "V60", 2013, "White", 250);
                Car fiat124Spider2018 = new Car("Fiat", "124 Spider", 2018, "Yellow", 160);
                Car landRoverRangeRoverSport2020 = new Car("Land Rover", "Range Rover Sport", 2020, "Green", 400);
                Car jeepCompass2015 = new Car("Jeep", "Compass", 2015, "Orange", 180);
                Car dodgeJourney2017 = new Car("Dodge", "Journey", 2017, "Gray", 173);
                Car gmcAcadia2012 = new Car("GMC", "Acadia", 2012, "Black", 288);
                Car teslaCybertruck2023 = new Car("Tesla", "Cybertruck", 2023, "Silver", 800);
                Car cadillacXT52015 = new Car("Cadillac", "XT5", 2015, "White", 310);
                Car astonMartinDB92015 = new Car("Aston Martin", "DB9", 2015, "Red", 540);
                Car subaruAscent2019 = new Car("Subaru", "Ascent", 2019, "Blue", 260);
                Car genesisGV802018 = new Car("Genesis", "GV80", 2018, "Black", 375);
                Car buickLaCrosse2016 = new Car("Buick", "LaCrosse", 2016, "Silver", 310);
                Car miniClubman2020 = new Car("Mini", "Clubman", 2020, "Green", 189);
                Car audiQ52016 = new Car("Audi", "Q5", 2016, "Gray", 252);
                Car lexusES3502012 = new Car("Lexus", "ES 350", 2012, "Red", 268);
                Car volkswagenTiguan2014 = new Car("Volkswagen", "Tiguan", 2014, "Blue", 200);
                Car bmw740i2017 = new Car("BMW", "740i", 2017, "Black", 320);
                Car landRoverEvoque2018 = new Car("Land Rover", "Evoque", 2018, "White", 286);
                Car toyotaSienna2013 = new Car("Toyota", "Sienna", 2013, "Silver", 266);
                Car mercedesCLA2502015 = new Car("Mercedes-Benz", "CLA 250", 2015, "Black", 208);
                Car nissanMurano2010 = new Car("Nissan", "Murano", 2010, "Brown", 265);
                Car fordFusion2018 = new Car("Ford", "Fusion", 2018, "Red", 181);
                Car hondaFit2016 = new Car("Honda", "Fit", 2016, "Blue", 130);
                Car chevroletCamaro2012 = new Car("Chevrolet", "Camaro", 2012, "Yellow", 426);
                Car audiA72018 = new Car("Audi", "A7", 2018, "Gray", 335);
                Car kiaSorento2011 = new Car("Kia", "Sorento", 2011, "Black", 191);
                Car jaguarXE2016 = new Car("Jaguar", "XE", 2016, "Green", 247);
                Car subaruBRZ2017 = new Car("Subaru", "BRZ", 2017, "Silver", 205);
                Car porscheMacan2015 = new Car("Porsche", "Macan", 2015, "Red", 252);
                Car teslaSemi2024 = new Car("Tesla", "Semi", 2024, "Silver", 1000);
                Car lexusNX3002019 = new Car("Lexus", "NX 300", 2019, "White", 235);
                Car lincolnMKZ2014 = new Car("Lincoln", "MKZ", 2014, "Black", 300);
                Car infinitiQ702020 = new Car("Infiniti", "Q70", 2020, "Blue", 330);
                Car volvoXC602016 = new Car("Volvo", "XC60", 2016, "Gray", 250);
                Car fiat500X2016 = new Car("Fiat", "500X", 2016, "Yellow", 160);
                Car landRoverDiscoverySport2017 = new Car("Land Rover", "Discovery Sport", 2017, "Green", 237);
                Car jeepRenegade2018 = new Car("Jeep", "Renegade", 2018, "Orange", 180);
                Car dodgeChallenger2014 = new Car("Dodge", "Challenger", 2014, "Black", 375);
                Car gmcSierra2019 = new Car("GMC", "Sierra", 2019, "White", 420);
                Car teslaModel42021 = new Car("Tesla", "Model 4", 2021, "Red", 480);
                Car cadillacXT42018 = new Car("Cadillac", "XT4", 2018, "Blue", 237);
                Car astonMartinRapide2012 = new Car("Aston Martin", "Rapide", 2012, "Silver", 558);
                Car subaruImpreza2015 = new Car("Subaru", "Impreza", 2015, "Blue", 148);
                Car genesisG702017 = new Car("Genesis", "G70", 2017, "Black", 252);
                Car buickEnvision2020 = new Car("Buick", "Envision", 2020, "White", 230);
                Car miniHardtop2019 = new Car("Mini", "Hardtop", 2019, "Green", 134);
                Car audiS42014 = new Car("Audi", "S4", 2014, "Gray", 349);
                Car lexusRC3502018 = new Car("Lexus", "RC 350", 2018, "Red", 311);
                Car volkswagenAtlas2020 = new Car("Volkswagen", "Atlas", 2020, "Black", 235);
                Car bmw540i2016 = new Car("BMW", "540i", 2016, "Gray", 335);
                Car landRoverRangeRoverEvoque2022 = new Car("Land Rover", "Range Rover Evoque", 2022, "White", 300);
                Car toyotaTacoma2012 = new Car("Toyota", "Tacoma", 2012, "Red", 278);
                Car mercedesAMGGLE632020 = new Car("Mercedes-Benz", "AMG GLE 63", 2020, "Blue", 603);
                Car nissanVersa2013 = new Car("Nissan", "Versa", 2013, "Black", 122);
                Car fordEdge2017 = new Car("Ford", "Edge", 2017, "Silver", 245);
                Car hondaOdyssey2015 = new Car("Honda", "Odyssey", 2015, "Gray", 280);
                Car chevroletEquinox2019 = new Car("Chevrolet", "Equinox", 2019, "Blue", 170);
                Car audiA82017 = new Car("Audi", "A8", 2017, "White", 450);
                Car kiaRio2016 = new Car("Kia", "Rio", 2016, "Red", 138);
                Car jaguarXK2014 = new Car("Jaguar", "XK", 2014, "Silver", 385);
                Car subaruXVCrosstrek2018 = new Car("Subaru", "XV Crosstrek", 2018, "Orange", 152);
                Car porsche718Cayman2019 = new Car("Porsche", "718 Cayman", 2019, "Yellow", 300);
                Car teslaModelY2022 = new Car("Tesla", "Model Y", 2022, "Blue", 450);
                Car lexusRX450h2013 = new Car("Lexus", "RX 450h", 2013, "Brown", 295);
                Car lincolnMKX2011 = new Car("Lincoln", "MKX", 2011, "Black", 305);
                Car infinitiQX802020 = new Car("Infiniti", "QX80", 2020, "Black", 400);
                Car volvoXC402014 = new Car("Volvo", "XC40", 2014, "White", 187);
                Car fiat500L2017 = new Car("Fiat", "500L", 2017, "Green", 160);
                Car landRoverRangeRoverVelar2021 = new Car("Land Rover", "Range Rover Velar", 2021, "Gray", 340);
                Car jeepPatriot2014 = new Car("Jeep", "Patriot", 2014, "Red", 158);
                Car dodgeNitro2010 = new Car("Dodge", "Nitro", 2010, "Blue", 210);
                Car gmcCanyon2018 = new Car("GMC", "Canyon", 2018, "Black", 308);
                Car teslaModelSPlaid2023 = new Car("Tesla", "Model S Plaid", 2023, "Silver", 1100);
                Car cadillacXT62019 = new Car("Cadillac", "XT6", 2019, "White", 310);
                Car astonMartinDBS2020 = new Car("Aston Martin", "DBS", 2020, "Red", 715);
                Car subaruOutback2021 = new Car("Subaru", "Outback", 2021, "Green", 182);
                Car genesisG802020 = new Car("Genesis", "G80", 2020, "Black", 375);
                Car buickRegal2016 = new Car("Buick", "Regal", 2016, "Silver", 250);
                Car miniCooperCountryman2018 = new Car("Mini", "Cooper Countryman", 2018, "Green", 189);
                Car audiQ32015 = new Car("Audi", "Q3", 2015, "Gray", 200);
                Car lexusIS3502017 = new Car("Lexus", "IS 350", 2017, "Red", 311);
                Car volkswagenGolf2019 = new Car("Volkswagen", "Golf", 2019, "Blue", 147);
                Car bmw330i2014 = new Car("BMW", "330i", 2014, "Black", 255);
                Car landRoverDiscovery2020 = new Car("Land Rover", "Discovery", 2020, "White", 340);
                Car toyotaAvalon2018 = new Car("Toyota", "Avalon", 2018, "Silver", 301);
                Car mercedesAMGC632015 = new Car("Mercedes-Benz", "AMG C63", 2015, "Yellow", 503);
                Car nissanAltima2014 = new Car("Nissan", "Altima", 2014, "Black", 182);
                Car fordMustang2011 = new Car("Ford", "Mustang", 2011, "Blue", 305);
                Car hondaPilot2016 = new Car("Honda", "Pilot", 2016, "White", 280);
                Car chevroletSuburban2020 = new Car("Chevrolet", "Suburban", 2020, "Gray", 355);
                Car audiS52019 = new Car("Audi", "S5", 2019, "Red", 354);
                Car kiaStinger2018 = new Car("Kia", "Stinger", 2018, "Silver", 365);
                Car jaguarXF2020 = new Car("Jaguar", "XF", 2020, "Blue", 340);
                Car subaruForester2022 = new Car("Subaru", "Forester", 2022, "Silver", 182);
                Car porsche911GT32016 = new Car("Porsche", "911 GT3", 2016, "Black", 500);
                Car teslaModelX2021 = new Car("Tesla", "Model X", 2021, "Gray", 590);
                Car lexusGX4602015 = new Car("Lexus", "GX 460", 2015, "White", 301);
                Car lincolnNavigator2018 = new Car("Lincoln", "Navigator", 2018, "Black", 450);
                Car infinitiQ502017 = new Car("Infiniti", "Q50", 2017, "Red", 328);
                Car volvoXC902015 = new Car("Volvo", "XC90", 2015, "Blue", 316);
                Car fiat5002019 = new Car("Fiat", "500", 2019, "Red", 135);
                Car landRoverRangeRover2020 = new Car("Land Rover", "Range Rover", 2020, "White", 400);
                Car jeepWrangler2021 = new Car("Jeep", "Wrangler", 2021, "Gray", 285);
                Car dodgeCharger2017 = new Car("Dodge", "Charger", 2017, "Blue", 370);
                Car gmcYukon2015 = new Car("GMC", "Yukon", 2015, "White", 355);
                Car teslaModel32020 = new Car("Tesla", "Model 3", 2020, "Red", 440);
                Car cadillacEscalade2018 = new Car("Cadillac", "Escalade", 2018, "Black", 420);
                Car astonMartinDB112013 = new Car("Aston Martin", "DB11", 2013, "Silver", 600);
                Car subaruForester2016 = new Car("Subaru", "Forester", 2016, "Blue", 182);
                Car genesisG802017 = new Car("Genesis", "G80", 2017, "White", 311);
                Car buickRegal2021 = new Car("Buick", "Regal", 2021, "Black", 250);
                Car miniCooper2017 = new Car("Mini", "Cooper", 2017, "Green", 181);
                Car audiQ72018 = new Car("Audi", "Q7", 2018, "Gray", 335);
                Car lexusIS2502014 = new Car("Lexus", "IS 250", 2014, "Silver", 204);
                Car volkswagenJetta2015 = new Car("Volkswagen", "Jetta", 2015, "Red", 150);
                Car bmwX52020 = new Car("BMW", "X5", 2020, "Blue", 335);
                Car landRoverRangeRover2023 = new Car("Land Rover", "Range Rover", 2023, "White", 400);
                Car toyotaHighlander2015 = new Car("Toyota", "Highlander", 2015, "Black", 270);
                Car mercedesGLEClass2013 = new Car("Mercedes-Benz", "GLE-Class", 2013, "Silver", 302);
                Car nissanRogue2019 = new Car("Nissan", "Rogue", 2019, "Green", 170);
                Car fordExplorer2012 = new Car("Ford", "Explorer", 2012, "Gray", 290);
                Car hondaAccord2018 = new Car("Honda", "Accord", 2018, "Blue", 190);
                Car chevroletTahoe2016 = new Car("Chevrolet", "Tahoe", 2016, "Black", 355);
                Car audiA62014 = new Car("Audi", "A6", 2014, "White", 310);
                Car kiaOptima2015 = new Car("Kia", "Optima", 2015, "Red", 185);
                Car jaguarXJ2018 = new Car("Jaguar", "XJ", 2018, "Silver", 340);
                Car subaruLegacy2015 = new Car("Subaru", "Legacy", 2015, "Blue", 182);
                Car porscheCayenne2016 = new Car("Porsche", "Cayenne", 2016, "Black", 300);
                Car teslaModelX2017 = new Car("Tesla", "Model X", 2017, "Gray", 518);
                Car lexusGX4602019 = new Car("Lexus", "GX 460", 2019, "White", 301);
                Car lincolnContinental2015 = new Car("Lincoln", "Continental", 2015, "Black", 400);
                Car infinitiQX602014 = new Car("Infiniti", "QX60", 2014, "Red", 295);
                Car volvoS602015 = new Car("Volvo", "S60", 2015, "Blue", 250);
                Car fiatSpider2016 = new Car("Fiat", "Spider", 2016, "Yellow", 160);
                Car landRoverDefender2023 = new Car("Land Rover", "Defender", 2023, "Green", 296);
                Car jeepGrandCherokee2014 = new Car("Jeep", "Grand Cherokee", 2014, "White", 360);
                Car dodgeDurango2020 = new Car("Dodge", "Durango", 2020, "Black", 293);
                Car gmcTerrain2015 = new Car("GMC", "Terrain", 2015, "Silver", 182);
                Car teslaModelY2025 = new Car("Tesla", "Model Y", 2025, "Red", 450);
                Car cadillacCT62018 = new Car("Cadillac", "CT6", 2018, "Blue", 404);
                Car astonMartinVantage2015 = new Car("Aston Martin", "Vantage", 2015, "Black", 420);
                Car subaruCrosstrek2018 = new Car("Subaru", "Crosstrek", 2018, "Orange", 152);
                Car genesisG902018 = new Car("Genesis", "G90", 2018, "White", 365);
                Car buickEncore2016 = new Car("Buick", "Encore", 2016, "Silver", 138);
                Car miniCountryman2019 = new Car("Mini", "Countryman", 2019, "Green", 134);
                Car audiTT2015 = new Car("Audi", "TT", 2015, "Red", 220);
                Car lexusLC5002018 = new Car("Lexus", "LC 500", 2018, "Blue", 471);
                Car volkswagenPassat2015 = new Car("Volkswagen", "Passat", 2015, "Black", 174);
                Car bmwX32014 = new Car("BMW", "X3", 2014, "Gray", 248);
                Car landRoverVelar2020 = new Car("Land Rover", "Velar", 2020, "White", 380);
                Car toyotaRav42017 = new Car("Toyota", "RAV4", 2017, "Blue", 203);
                Car mercedesGLC3002015 = new Car("Mercedes-Benz", "GLC 300", 2015, "Silver", 255);
                Car nissanSentra2014 = new Car("Nissan", "Sentra", 2014, "Red", 130);
                Car fordEscape2016 = new Car("Ford", "Escape", 2016, "Green", 168);
                Car hondaCRV2019 = new Car("Honda", "CR-V", 2019, "White", 190);
                Car chevroletMalibu2018 = new Car("Chevrolet", "Malibu", 2018, "Black", 160);
                Car audiA32016 = new Car("Audi", "A3", 2016, "Gray", 170);
                Car kiaForte2019 = new Car("Kia", "Forte", 2019, "Red", 147);
                Car jaguarFType2018 = new Car("Jaguar", "F-Type", 2018, "Blue", 450);
                Car subaruWRX2016 = new Car("Subaru", "WRX", 2016, "Silver", 268);
                Car porschePanamera2016 = new Car("Porsche", "Panamera", 2016, "White", 330);
                Car teslaRoadster2023 = new Car("Tesla", "Roadster", 2023, "Red", 1000);
                Car lexusLS4602015 = new Car("Lexus", "LS 460", 2015, "Black", 386);
                Car lincolnMKC2017 = new Car("Lincoln", "MKC", 2017, "Silver", 240);
                Car infinitiQ602018 = new Car("Infiniti", "Q60", 2018, "Blue", 300);
                Car volvoV602014 = new Car("Volvo", "V60", 2014, "White", 250);
                Car fiat124Spider2016 = new Car("Fiat", "124 Spider", 2016, "Yellow", 160);
                Car landRoverRangeRoverSport2021 = new Car("Land Rover", "Range Rover Sport", 2021, "Green", 400);
                Car jeepCompass2016 = new Car("Jeep", "Compass", 2016, "Orange", 180);
                Car dodgeJourney2018 = new Car("Dodge", "Journey", 2018, "Gray", 173);
                Car gmcAcadia2015 = new Car("GMC", "Acadia", 2015, "Black", 288);
                Car teslaCybertruck2024 = new Car("Tesla", "Cybertruck", 2024, "Silver", 800);
                Car cadillacXT52016 = new Car("Cadillac", "XT5", 2016, "White", 310);
                Car astonMartinDB92016 = new Car("Aston Martin", "DB9", 2016, "Red", 540);
                Car subaruAscent2020 = new Car("Subaru", "Ascent", 2020, "Blue", 260);
                Car genesisGV802019 = new Car("Genesis", "GV80", 2019, "Black", 375);
                Car buickLaCrosse2017 = new Car("Buick", "LaCrosse", 2017, "Silver", 310);
                Car miniClubman2021 = new Car("Mini", "Clubman", 2021, "Green", 189);
                Car audiQ32017 = new Car("Audi", "Q3", 2017, "Gray", 252);
                Car lexusES3502014 = new Car("Lexus", "ES 350", 2014, "Red", 268);
                Car volkswagenTiguan2016 = new Car("Volkswagen", "Tiguan", 2016, "Blue", 200);

                // Example: Printing the details of each car 
                foreach (var car in cars)
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Horsepower: {car.Horsepower}");
                }
            }
        }
    }

//Mandag:
//Start med opbevaring af mindst 100 biler
// 1. Udskriv alle biler som deler mærke med den første bil i jeres datasæt 
// 2. udskrive alle biler som har over 200HK.
// 3. Udskriv alle røde biler
// 4. Udskriv alle biler som er melle årgang 1980 og 1999

//Tirsdag:
//Tjek jeres klasse igennem, er der noget som burde ændres ud fra abstraktions-pensummet? er jeres model for kompleks?
//udvid jeres program til at have 2 klasser, en for benzin/diesel biler og en for elbiler.
//Når i har set klassen igennem og er tilfredse skal i udvide med et interface 
//Interfaces skal gøre at alle bil-klassser skal have en pris, model og mærke 

//Onsdag:
//Nu skal alle jeres attributter være private, hvis de ikke allerede er det. Virker jeres program stadig? Hvis ikke skal i definere Get og Set metoder, så det virker igen!
//Bagefter kan i begynde at diagrammere jeres UML Diagram 

//Torsdag:
//Jeres bilsægler side, vil nu gerne udvide til både at have benzin/diesel biler, elbiler og motercykler, 
//de skal bruge e klasse hver og i skal lave en klasse somde alle sammen arver fra.
//I bestemmmer selv, om det er en abstrakt klasse eller bare en normal klasse som de andre arver.
//her er det vigtigt at bruge konceptere fra abstraktion og overveje, hvad der skal i hver klasse!

//Fredag: 
//Igen opgaver til polymorfi - vi sætter fokus på jeres projekt og i for muligheden for at opbygge eller arbejde videre med klasserne til det lange selvvalgte projekt.

