using Classses;
using System.Reflection.Emit;

namespace BilbasenKonsol
{
        internal class Program
        {

            public static List<Car> pertrol_dieselCars = new List<Car>()
                    {
                    new Car("Ford", "Mustang", 1963, "Red", 430, "Petrol"),
                    new Car("Toyota", "Camry", 2020, "Blue", 200, "Petrol"),
                    new Car("Chevrolet", "Corvette", 2022, "Silver", 650, "Petrol"),
                    new Car("Honda", "Civic", 2015, "White", 158, "Petrol"),
                    new Car("BMW", "3 Series", 2019, "Black", 320, "Diesel"),
                    new Car("Audi", "A6", 2018, "Gray", 255, "Diesel"),
                    new Car("Mercedes-Benz", "CLS", 2021, "Silver", 362, "Petrol"),
                    new Car("Volkswagen", "Golf", 2017, "Blue", 148, "Petrol"),
                    new Car("Porsche", "911", 2023, "Yellow", 450, "Petrol"),     
                    new Car("Ferrari", "F812", 2020, "Red", 789, "Petrol"),
                    new Car("Dodge", "Charger", 2016, "Black", 292, "Petrol"),
                    new Car("Subaru", "WRX", 2018, "Blue", 268, "Petrol"),
                    new Car("Lexus", "RX 350", 2021, "Silver", 295, "Petrol"),
                    new Car("Jeep", "Wrangler", 2022, "Green", 285, "Petrol"),
                    new Car("Hyundai", "Sonata", 2019, "Gray", 180, "Petrol"),
                    new Car("Nissan", "GT-R", 2022, "Black", 565, "Petrol"),
                    new Car("Kia", "Optima", 2017, "White", 185, "Petrol"),
                    new Car("Volvo", "XC90", 2020, "Blue", 316, "Diesel"),
                    new Car("Mazda", "MX-5", 2018, "Red", 181, "Petrol"),
                    new Car("Infiniti", "Q50", 2021, "Black", 300, "Diesel"),
                    new Car("Jaguar", "XF", 2019, "Silver", 296, "Diesel"),
                    new Car("Genesis", "G80", 2023, "Gray", 375, "Petrol"),
                    new Car("Land Rover", "Discovery", 2017, "White", 254, "Diesel"),
                    new Car("Buick", "Regal", 2021, "Black", 250, "Petrol"),
                    new Car("Tesla", "Model 3", 2025, "Blue", 221, "Electric"),
                    new Car("Fiat", "500", 2016, "Red", 101, "Petrol"),
                    new Car("Mini", "Cooper", 2020, "Yellow", 134, "Petrol"),
                    new Car("Lincoln", "Navigator", 2023, "Silver", 450, "Diesel"),
                    new Car("Maserati", "Ghibli", 2019, "Blue", 345, "Diesel"),
                    new Car("Chrysler", "300C", 2021, "Black", 363, "Petrol"),
                    new Car("Bentley", "Continental GT", 2018, "White", 626, "Petrol"),
                    new Car("Aston Martin", "DB11", 2022, "Gray", 630, "Petrol"),
                    new Car("Rolls-Royce", "Phantom", 2020, "Black", 563, "Diesel"),
                    new Car("Bugatti", "Chiron", 2023, "Blue", 1500, "Petrol"),
                    new Car("Lamborghini", "Aventador", 2024, "Orange", 730, "Petrol"),
                    new Car("Alfa Romeo", "Giulia", 2017, "Red", 276, "Diesel"),
                    new Car("Subaru", "Outback", 2022, "Green", 182, "Diesel"),
                    new Car("Lexus", "ES 350", 2020, "Silver", 302, "Petrol"),
                    new Car("Audi", "Q7", 2021, "Gray", 335, "Diesel"),
                    new Car("Mercedes-AMG", "GLC 63", 2023, "Black", 469, "Petrol"),
                    new Car("Volkswagen", "Passat", 2019, "White", 174, "Diesel"),
                    new Car("Porsche", "Panamera", 2020, "Blue", 325, "Diesel"),
                    new Car("Jaguar", "F-Type", 2021, "Red", 444, "Petrol"),
                    new Car("BMW", "X5", 2022, "Silver", 523, "Diesel"),
                    new Car("Land Rover", "Range Rover", 2023, "Black", 395, "Diesel"),
                    new Car("Bentley", "Flying Spur", 2019, "White", 626, "Petrol"),
                    new Car("Cadillac", "CT5", 2020, "Gray", 335, "Diesel"),
                    new Car("Rolls-Royce", "Cullinan", 2021, "Black", 563, "Diesel"),
                    new Car("Aston Martin", "Vantage", 2018, "Blue", 503, "Petrol"),
                    new Car("Ferrari", "Portofino", 2023, "Red", 612, "Petrol"),
                    new Car("Lamborghini", "Huracan", 2024, "Yellow", 630, "Petrol"),
                    new Car("McLaren", "570S", 2021, "Orange", 562, "Petrol"),
                    new Car("Alfa Romeo", "Stelvio", 2019, "White", 276, "Diesel"),
                    new Car("Buick", "Enclave", 2022, "Black", 310, "Petrol"),
                    new Car("Cadillac", "Escalade", 2018, "Silver", 420, "Petrol"),
                    new Car("Lincoln", "Aviator", 2021, "Blue", 400, "Diesel"),
                    new Car("Genesis", "GV80", 2023, "White", 375, "Petrol"),
                    new Car("Infiniti", "QX50", 2019, "Black", 268, "Diesel"),
                    new Car("Kia", "Sorento", 2020, "Red", 281, "Petrol"),
                    new Car("Maserati", "Levante", 2018, "Gray", 345, "Diesel"),
                    new Car("Nissan", "Pathfinder", 2021, "Blue", 284, "Diesel"),
                    new Car("Subaru", "Forester", 2017, "Green", 182, "Diesel"),
                    new Car("Tesla", "Model X", 2024, "White", 1, "Electric"),
                    new Car("Toyota", "RAV4", 2022, "Silver", 219, "Petrol"),
                    new Car("Volvo", "XC60", 2019, "Black", 316, "Diesel"),
                    new Car("VW", "Atlas Cross Sport", 2023, "Red", 276, "Diesel"),
                    new Car("Mazda", "CX-5", 2020, "Blue", 187, "Petrol"),
                    new Car("BMW", "M5", 2018, "Black", 600, "Petrol"),
                    new Car("Audi", "RS7", 2022, "Gray", 591, "Petrol"),
                    new Car("Mercedes-Benz", "GLE 450", 2021, "White", 362, "Petrol"),
                    new Car("Land Rover", "Defender", 2020, "Green", 296, "Diesel"),
                    new Car("Porsche", "Cayenne", 2023, "Black", 541, "Diesel"),
                    new Car("Jaguar", "I-Pace", 2024, "Blue", 394, "Electric"),
                    new Car("Ford", "F-150", 2021, "Red", 400, "Petrol"),
                    new Car("Chevrolet", "Silverado", 2020, "Blue", 355, "Petrol"),
                    new Car("Dodge", "RAM 1500", 2019, "Black", 305, "Petrol"),
                    new Car("GMC", "Sierra", 2023, "White", 420, "Petrol"),
                    new Car("Toyota", "Tacoma", 2018, "Gray", 278, "Petrol"),
                    new Car("Nissan", "Titan", 2022, "Silver", 400, "Petrol"),
                    new Car("Honda", "Ridgeline", 2017, "Red", 280, "Petrol"),
                    new Car("Jeep", "Gladiator", 2021, "Black", 285, "Petrol"),
                    new Car("RAM", "2500", 2020, "Gray", 400, "Diesel"),
                    new Car("Chevrolet", "Colorado", 2019, "Orange", 308, "Petrol"),
                    new Car("Ford", "Ranger", 2023, "Blue", 270, "Diesel"),
                    new Car("GMC", "Canyon", 2018, "White", 181, "Diesel"),
                    new Car("Toyota", "Tundra", 2021, "Black", 381, "Petrol"),
                    new Car("Nissan", "Frontier", 2022, "Silver", 310, "Petrol"),
                    new Car("Honda", "HR-V", 2019, "Blue", 141, "Petrol"),
                    new Car("Subaru", "Crosstrek", 2020, "Orange", 152, "Petrol"),
                    new Car("Hyundai", "Tucson", 2023, "White", 187, "Petrol"),
                    new Car("Kia", "Sportage", 2018, "Red", 181, "Diesel"),
                    new Car("Mazda", "CX-3", 2021, "Black", 148, "Petrol"),
                    new Car("Jeep", "Compass", 2019, "Gray", 180, "Diesel"),
                    new Car("VW", "Tiguan", 2022, "Blue", 184, "Petrol"),
                    new Car("Ford", "Escape", 2020, "Silver", 250, "Petrol"),
                    new Car("Chevrolet", "Equinox", 2017, "Black", 170, "Diesel"),
                    new Car("Dodge", "Journey", 2018, "Red", 172, "Petrol"),
                    new Car("GMC", "Terrain", 2021, "White", 170, "Diesel"),
                    new Car("Jeep", "Cherokee", 2024, "Gray", 271, "Petrol"),
                    new Car("RAM", "1500", 2019, "Blue", 395, "Petrol"),
                    new Car("Toyota", "Highlander", 2022, "Black", 295, "Petrol"),
                    
                    };

            public static List<Car> electricalCars = new List<Car>()
                    {
                    new Car("Tesla", "Model S", 2024, "White", 670, "Electric"),
                    new Car("Tesla", "Model 3", 2025, "Blue", 221, "Electric"),
                    new Car("Tesla", "Model X", 2024, "White", 1, "Electric"),
                    new Car("Tesla", "Model Y", 2025, "Red", 480, "Electric"),
                    new Car("Audi", "e-tron", 2022, "Silver", 355, "Electric"),
                    new Car("BMW", "i3", 2023, "Blue", 170, "Electric"),
                    new Car("BMW", "i4", 2022, "White", 523, "Electric"),
                    new Car("BMW", "iX3", 2024, "Black", 286, "Electric"),
                    new Car("BMW", "iX4", 2021, "Red", 326, "Electric"),
                    new Car("BMW", "iX5", 2022, "Silver", 523, "Electric"),
                    new Car("Chevrolet", "Bolt EV", 2023, "Blue", 200, "Electric"),
                    new Car("Ford", "Mustang Mach-E", 2024, "Red", 480, "Electric"),
                    new Car("Hyundai", "Kona Electric", 2022, "Black", 201, "Electric"),
                    new Car("Jaguar", "I-Pace", 2024, "Blue", 394, "Electric"),
                    new Car("Kia", "Niro EV", 2021, "Gray", 201, "Electric"),
                    new Car("Nissan", "Leaf", 2022, "Green", 147, "Electric"),
                    new Car("Porsche", "Taycan", 2023, "White", 469, "Electric"),
                    new Car("Rivian", "R1T", 2024, "Orange", 750, "Electric"),
                    new Car("Rivian", "R1S", 2024, "Blue", 750, "Electric"),
                    new Car("Polestar", "2", 2023, "Gray", 300, "Electric"),
                    new Car("Volkswagen", "ID.3", 2024, "Blue", 201, "Electric"),
                    new Car("Volkswagen", "ID.4", 2022, "Silver", 276, "Electric"),
                    new Car("Volvo", "XC40 Recharge", 2025, "Black", 402, "Electric"),
                    new Car("Lucid", "Air", 2023, "White", 1080, "Electric"),
                    new Car("Byton", "M-Byte", 2024, "Black", 272, "Electric"),
                    new Car("Bollinger", "B2", 2024, "Yellow", 614, "Electric"),
                    new Car("Lordstown", "Endurance", 2024, "Gray", 600, "Electric"),
                    new Car("Lightning E-Motorcycles", "LS-218", 2023, "Red", 200, "Electric"),
                    new Car("Rimac", "Nevera", 2022, "Blue", 1914, "Electric"),
                    new Car("Tesla", "Roadster", 2023, "Silver", 1000, "Electric"),

                    };

        public static void Main()
            {
                Label:
                Console.Clear();
                Console.WriteLine("Which cars would you like to search in \n1. Electrical cars\n2. Petrol and Diesel");
                string choice = Console.ReadLine();
                switch (choice)
                    {
                        case "1":
                            SearchMenu(pertrol_dieselCars);
                            break;

                        case "2":
                            SearchMenu(electricalCars);
                            break;

                    }
        }
        public static void SearchMenu(List<Car> list)
        {
            Console.WriteLine("Which menu do you want to use?\n1. Show all cars with the same brand as the first car in the database.\n2. Show all cars with 200 or more HK.\n3. Show all red cars.");
            Console.WriteLine("4. Show amount of cars with the same brand as the first car in the database.\n5. Show cars from 1980 - 1999.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FirstBrandInDatabase(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "2":
                    MoreThen200HK(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "3":
                    RedCars(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "4":
                    AmountOfCarsWithTheFirstBrandInTheDatabase(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "5":
                    CarsFrom80_99(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                default:
                    Main();
                    break;
            }
        }
        public static void FirstBrandInDatabase(List<Car> list)
            {
            Console.WriteLine($"\nCars matching the Brand 'Ford':");
            foreach (Car car in list)
            {
                if (car.Brand == "Ford")
                {
                Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.FuelType}.\n");
            }
        }
    }
        public static void MoreThen200HK(List<Car> list)
{
    Console.WriteLine("\nCars with more then 200 HK:");
    foreach (Car car in list)
    {
        if (car.HorsePower >= 200)
        {
            Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.FuelType}.\n");
        }
    }
}
public static void RedCars(List<Car> list)
{
    Console.WriteLine("\nCars that are red:");
    foreach (Car car in list)
    {
        if (car.Color == "Red")
        {
            Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.FuelType}.\n");
        }
    }
}
public static void AmountOfCarsWithTheFirstBrandInTheDatabase(List<Car> list)
{
    int carAmount = 0;
    foreach (Car car in list)
    {
        if (car.Brand == "Ford")
        {
            carAmount++;
        }
    }
    Console.WriteLine($"Amount of cars of the brand 'Ford': {carAmount}.\n");
}
public static void CarsFrom80_99(List<Car> list)
{
    Console.WriteLine("Cars from 1980 - 1999.");
    foreach (Car car in list)
    {
        if (car.Year >= 1980 && car.Year <= 1999)
        {
            Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.FuelType}.\n");
        }
    }
}
    }
}


//OPGAVE PROGRAM:
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

