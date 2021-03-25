using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Group Members Kehvoi Thompson, Amanda Perce and Joshua Johnson
namespace ShopChoiceSystem
{

   
    class Program
    {
      
        

        static void Main(string[] args)
        {
            

            int Tissue = 50;
            int TissueAm = 0;
            int BathSoap = 90;
            int BathSoapAm = 0;

            int Bread = 350;
            int TrayOfEggs = 320;
            int OrangeJuice = 370;
            int CornedBeef = 250;
            int Ketchup = 340;
            int Milk = 170;
            int RicePerLb = 90;
            int FlourPerLb = 70;
            int CranberryJuice = 230;
            int GreenTea = 140;

            int BreadAm = 0;
            int TrayOfEggsAm = 0;
            int OrangeJuiceAm = 0;
            int CornedBeefAm = 0;
            int KetchupAm = 0;
            int MilkAm = 0;
            int RicePerLbAm = 0;
            int FlourPerLbAm = 0;
            int CranberryJuiceAm= 0;
            int GreenTeaAm = 0;


            int Toster = 2300;
            int Fan = 5700;
            int BluetoothSpeakers = 1500;
            int Earphones = 150;
            int SamsungEarphones = 700;
            int Earpods = 2400;

            int TosterAm = 0;
            int FanAm = 0;
            int BluetoothSpeakersAm = 0;
            int EarphonesAm = 0;
            int SamsungEarphonesAm = 0;
            int EarpodsAm = 0;
        

            string ip = "";
            string c1 = "";
            string c2 = "";
            string c3 = "";
            string c4 = "";
            string c5 = "";
            string c6 = "";

            Double CustomerMoney;
            float CustomerPays;

            int CustomerBill;
            int TissueNum = 0;
            int BathSoapNum = 0;
            List<int> Total = new List<int>();
            List<int> TotalTwo = new List<int>(0);
            Dictionary<string, int> Items = new Dictionary<string, int>();
            DateTime CurrentDate = DateTime.Now;
            string Cashier = "Admin";


            while (ip !="e" ) {
            Console.Clear();
            Console.WriteLine("++++MENU++++");
            Console.WriteLine("Enter Items (1)");
            Console.WriteLine("Change Cashier (2)");
            Console.WriteLine("Exit (e)");
            ip = Console.ReadLine();

            switch (ip)
            {
                    case "1":
                        while (c1 != "c")
                        {
                            Console.Clear();
                            Console.WriteLine("^^^^Select Items that are being Purchased^^^^");
                       
                            Console.WriteLine(" Home Products (1) \n Groceries (2) \n Electronic Appliances (3) \n Checkout (4)");
                        
                            c1 = Console.ReadLine();
                            switch (c1)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("\\\\Home Products//// \n Select Item");
                                    Console.WriteLine(" Tissue $" + Tissue + " (1)");
                                    Console.WriteLine(" BathSoap $" + BathSoap + " (2)");
                                    Console.WriteLine(" Return (3) ");


                                    c2 = Console.ReadLine();
                                    switch (c2)
                                    {
                                        case "1":
                                            Console.WriteLine(" Enter Tissue Quantity ");
                                            TissueAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = Tissue * TissueAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            Total.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Tissue: $" + Tissue , TissueAm);
                                            break;

                                        case "2":
                                            Console.WriteLine(" Enter BathSoap Quantity ");
                                            BathSoapAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = BathSoap * BathSoapAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            Total.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Bath Soap: $" + BathSoap , BathSoapAm);
                                            break;

                                        case "3":
                                            Console.WriteLine("Return");
                                            break;
                                    }

                                    break;

                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("^^^^Groceries^^^^ \n Select Item");
                                    Console.WriteLine(" Bread $" + Bread + " (1)");
                                    Console.WriteLine(" Tray of Eggs $" + TrayOfEggs + " (2)");
                                    Console.WriteLine(" Orange Juice $" + OrangeJuice + " (3)");
                                    Console.WriteLine(" Cow's Milk $" + Milk + " (4)");
                                    Console.WriteLine(" Corned Beef $" + CornedBeef + " (5)");
                                    Console.WriteLine(" Cranberry Juice $" + CranberryJuice + " (6)");
                                    Console.WriteLine(" Flour (Per pound) $" + FlourPerLb + " (7)");
                                    Console.WriteLine(" Rice (Per pound) $" + RicePerLb + " (8)");
                                    Console.WriteLine(" Return (9) ");
                                    c4 = Console.ReadLine();
                                    switch (c4)
                                    {
                                        case "1":
                                            Console.WriteLine(" Enter Bread Quantity ");
                                            BreadAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = Bread * BreadAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            TotalTwo.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Bread: $" + Bread, BreadAm);
                                            break;

                                        case "2":
                                            Console.WriteLine(" Enter Tray Of Eggs Quantity ");
                                            TrayOfEggsAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = TrayOfEggs * TrayOfEggsAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            TotalTwo.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Tray Of Eggs: $" + TrayOfEggs, TrayOfEggsAm);
                                            break;

                                        case "3":
                                            Console.WriteLine(" Enter the Quantity of Orange Juice ");
                                            OrangeJuiceAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = OrangeJuice * OrangeJuiceAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            TotalTwo.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Orange Juice: $" + OrangeJuice, OrangeJuiceAm);

                                            break;

                                        case "4":
                                            Console.WriteLine(" How many boxes of Milk ");
                                            MilkAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = Milk * MilkAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            TotalTwo.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Milk: $" + Milk, MilkAm);

                                            break;

                                        case "5":
                                            Console.WriteLine(" Enter the Quantity of tins of Cornedbeef ");
                                            CornedBeefAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = CornedBeef * CornedBeefAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            TotalTwo.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Corned Beef $" + CornedBeef, CornedBeefAm);
                                            break;

                                        case "6":
                                            Console.WriteLine("  Cranberry Juice Quantity? ");
                                            CranberryJuiceAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = CranberryJuice * CranberryJuiceAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            TotalTwo.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Cranberry Juice: $" + CranberryJuice, CranberryJuiceAm);
                                            break;

                                        case "7":
                                            Console.WriteLine(" Pounds of Flour Quantity");
                                            FlourPerLbAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = FlourPerLb * FlourPerLbAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            TotalTwo.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Pounds of Flour: $" + FlourPerLb, FlourPerLbAm);
                                            break;

                                        case "8":
                                            Console.WriteLine(" Pounds of Rice Quantity");
                                            RicePerLbAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = RicePerLb * RicePerLbAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            TotalTwo.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Pounds of Rice: $" + RicePerLb, RicePerLbAm);
                                            break;
                                    }

                                    break;

                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("----Electronic Appliances----  \n Select Item");
                                    Console.WriteLine("Toaster $" + Toster + "(1)");
                                    Console.WriteLine(" Fan $" + Fan + " (2)");
                                    Console.WriteLine(" Bluetooth Speakers $" + BluetoothSpeakers + " (3)");
                                    Console.WriteLine(" Earphones $" + Earphones + " (4)");
                                    Console.WriteLine(" Samsung Earphones $" + SamsungEarphones + " (5)");
                                    Console.WriteLine(" Earpods $" + Earpods + " (6)");
                                    Console.WriteLine("Return (7)");
                                    c5 = Console.ReadLine();

                                    switch (c5)
                                    {
                                        case "1":
                                            Console.WriteLine(" Tosters Quantity");
                                            TosterAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = Toster * TosterAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            Total.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Toster: $" + Toster, TosterAm);
                                            break;

                                        case "2":
                                            Console.WriteLine(" Fans Quantity");
                                            FanAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = Fan * FanAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            Total.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Fan: $" + Fan, FanAm);
                                            break;
                                        case "3":
                                            Console.WriteLine(" Bluetooth Speakers Quantity ");
                                            BluetoothSpeakersAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = BluetoothSpeakers * BluetoothSpeakersAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            Total.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Bluetooth Speakers:  $" + BluetoothSpeakers, BluetoothSpeakersAm);
                                            break;
                                        case "4":
                                            Console.WriteLine(" Enter Earphone Quantity ");
                                            EarphonesAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = Earphones * EarphonesAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            Total.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Earphones: $" + Earphones, EarphonesAm);
                                            break;
                                        case "5":
                                            Console.WriteLine(" Enter Samsung Earphones Quantity ");
                                            SamsungEarphonesAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = SamsungEarphones * SamsungEarphonesAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            Total.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Samsung Earphones: $" + SamsungEarphones, SamsungEarphonesAm);
                                            break;
                                        case "6":
                                            Console.WriteLine(" Enter Earpods Quantity ");
                                            EarpodsAm = Convert.ToInt32(Console.ReadLine());
                                            CustomerBill = Earpods * EarpodsAm;
                                            Console.WriteLine("$" + CustomerBill);
                                            Total.Add(CustomerBill);
                                            Console.Beep();
                                            Items.Add("Earpods: $" + Earphones, EarpodsAm);
                                            break;
                                    }

                                    break;

                                case "4":
                                    Console.Clear();
                                    Console.WriteLine("  +-~Checkout~-+  ");
                                    Console.WriteLine("\n Customer Bill \n");

                                    Console.WriteLine("             Shop Choice Store");
                                    Console.WriteLine("     30E Constant Spring Road, Kingston 10");
                                    Console.WriteLine("     Tel: 876-827-0879");
                                    Console.WriteLine("     Cashier: " + Cashier);
                                    Console.WriteLine(CurrentDate.ToString("     DATE: ddd MMM %d, yyyy"));
                                    Console.Write("     Time:");
                                    Console.WriteLine(CurrentDate.ToString("hh:mm:ss tt"));
                                    Console.WriteLine("\n   Items");

                                    int sum = 0;
                                    int sumTwo = 0;
                                    int OutSum = 0;
                                    int InSum = 0;
                                    float SurSum = 0f;

                                    foreach(KeyValuePair<string, int> ele2 in Items)
                                    {
                                        Console.WriteLine("{0} x {1}", ele2.Key, ele2.Value);
                                    }

                                    foreach ( int element in Total)
                                    {
                                        
                                        sum += element;
                                        OutSum = sum;
                                    }
                                    
                                    Console.WriteLine("\nPrice for Home Products and Electronic Appliances: $" + OutSum);
                                    int JamTax = 120;
                                    int TotalGct = JamTax * OutSum / 100;
                                    Console.WriteLine("Price for Home Products and Electronic Appliances plus GCT: $" + TotalGct );
                                    foreach (int element in TotalTwo)
                                    {
                                        sumTwo += element;
                                        InSum = sumTwo;
                                    }
                                    Console.WriteLine("The Groceries price: $" + InSum);
                                    float Gtax = 117.5f;
                                    float Ggct = Gtax * InSum / 100;
                                    Console.WriteLine("The Grocerie price plus Gct: $" + Ggct);
                                    
                                    SurSum = TotalGct + Ggct;
                                    Console.WriteLine("The overall Price: $" + SurSum);
                                    if (SurSum > 0.99 && SurSum < 10000.00) {
                                        Console.WriteLine("\n This Customer will recieve the Silver Class Discount");
                                        int Silver = 1;
                                        float SilverR = SurSum * Silver / 100;
                                        float PrintS = SurSum - SilverR;
                                        Console.WriteLine("The customer recieved a discount of " + Silver +"% Grand Total is now: $" + PrintS );
                                        Console.WriteLine("Enter the ammount paied by the customer");
                                        CustomerPays = float.Parse(Console.ReadLine());
                                        CusChange(CustomerPays,PrintS);
                                        Total.Clear();
                                        TotalTwo.Clear();

                                    }
                                    if(SurSum > 10001.00 && SurSum < 20000.00){

                                        Console.WriteLine("\n This Customer will recieve the Gold Class Discount");
                                        int Gold = 5;
                                        float GoldR = SurSum * Gold / 100;
                                        float PrintG = SurSum - GoldR;
                                        Console.WriteLine("The customer recieved a discount of " + Gold + "% Grand Total is now: $" + PrintG);
                                        CustomerPays = float.Parse(Console.ReadLine());
                                        CusChange(CustomerPays, PrintG);
                                        Total.Clear();
                                        TotalTwo.Clear();
                                    }
                                    if(SurSum > 20001.00)
                                    {
                                        Console.WriteLine("\n This Customer will recieve the Platinum Class Discount");
                                        int Platinum = 10;
                                        float PlatinumR = SurSum * Platinum / 100;
                                        float PrintP = SurSum - PlatinumR;
                                        Console.WriteLine("The customer recieved a discount of " + Platinum + "% Grand Total is now: $" + PrintP);
                                        CustomerPays = float.Parse(Console.ReadLine());
                                        CusChange(CustomerPays, PrintP);
                                        Total.Clear();
                                        TotalTwo.Clear();
                                    }


                                    


                                    // Need to clear the list after this
                                    Total.Clear();
                                    TotalTwo.Clear();
                                    Items.Clear();
                                    Console.Read();
                                    break;
                            }
                        }
                        
                        
                    break;
                case "2": Console.WriteLine("Enter Cashier's Name");
                         Cashier = Console.ReadLine();
                        
                        break;
                case "e":
                        Console.WriteLine("Press Enter Again to Close Application");
                        break;
                }
          }


            Console.ReadKey();
        }

        static void CusChange(float num1, float num2)
        {
          
          float Giveback = num1 - num2;
            if(num1 < num2)
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Clear();
                Console.WriteLine("Insufficent ammount, this customer cannot make a purchase");
            }
            else
            {
                Console.WriteLine("Give $" + Giveback + " back to the Customer");
            }
            
            
        }

    }
}


