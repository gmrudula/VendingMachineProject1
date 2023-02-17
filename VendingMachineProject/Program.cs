using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject
{
    public class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product(1, "cola", 1.00);
            Product p2 = new Product(2, "chips", 0.50);
            Product p3 = new Product(3, "candy", 0.65);
            do
            {
                double CustomerBill = 0.00;
                double enteredMoney = 0.00;

                int SelectedProduct = 0;
                double balance = 0.00;
                Console.WriteLine("Please select the product you want to buy");

                Console.WriteLine("{0,-8}{1,-15}{2,0}", "S.No", "Products", "Price");
                Console.WriteLine("{0,-8}{1,-15}{2,0}", p1.ProductId.ToString(), p1.ProductName, p1.Price);
                Console.WriteLine("{0,-8}{1,-15}{2,0}", p2.ProductId.ToString(), p2.ProductName, p2.Price);
                Console.WriteLine("{0,-8}{1,-15}{2,0}", p3.ProductId.ToString(), p3.ProductName, p3.Price);


                SelectedProduct = int.Parse(Console.ReadLine());
                switch (SelectedProduct)
                {
                    case 1:
                        while (CustomerBill != p1.Price)
                        {
                            Console.WriteLine("Please insert the money to buy the product:");
                            enteredMoney = double.Parse(Console.ReadLine());
                            bool value = ValidateEnteredMoney(enteredMoney);
                            if (value)
                            {
                                CustomerBill += enteredMoney;
                                if (CustomerBill == p1.Price)
                                {
                                    Console.WriteLine("amount received. Please collect the product from vending machine");
                                }
                                else if (CustomerBill > p1.Price)
                                {
                                    balance = CustomerBill - p1.Price;
                                    Console.WriteLine("please collect the remaining balance and the product");
                                    Console.WriteLine("balance amount:" + balance);
                                    break;
                                }
                                else
                                {
                                    balance = p1.Price - CustomerBill;
                                    Console.WriteLine("please insert balance money to buy the product");
                                    Console.WriteLine("balance amount:" + balance);


                                }
                            }
                            else
                            {
                                //Console.WriteLine("coin is not valid. please insert the valid coins. valid coins are :" + c1.coinValue + "," + c2.coinValue + "," + c3.coinValue);
                                Console.WriteLine("coin is not valid. please insert the valid coins.");
                            }

                        }

                        break;
                    case 2:
                        while (CustomerBill != p2.Price)
                        {
                            Console.WriteLine("Please insert the money to buy the product:");
                            enteredMoney = double.Parse(Console.ReadLine());
                            bool value = ValidateEnteredMoney(enteredMoney);
                            if (value)
                            {
                                CustomerBill += enteredMoney;
                                if (CustomerBill == p2.Price)
                                {
                                    Console.WriteLine("amount received. Please collect the product from vending machine");
                                }
                                else if (CustomerBill > p2.Price)
                                {
                                    balance = CustomerBill - p2.Price;
                                    Console.WriteLine("please collect the remaining balance and the product");
                                    Console.WriteLine("balance amount:" + balance);
                                    break;
                                }
                                else
                                {
                                    balance = p2.Price - CustomerBill;
                                    Console.WriteLine("please insert balance money to buy the product");
                                    Console.WriteLine("balance amount:" + balance);


                                }
                            }
                            else
                            {
                                //Console.WriteLine("coin is not valid. please insert the valid coins. valid coins are :" + c1.coinValue + "," + c2.coinValue + "," + c3.coinValue);
                                Console.WriteLine("coin is not valid. please insert the valid coins.");
                            }

                        }

                        break;

                    case 3:
                        while (CustomerBill != p3.Price)
                        {
                            Console.WriteLine("Please insert the money to buy the product:");
                            enteredMoney = double.Parse(Console.ReadLine());
                            bool value = ValidateEnteredMoney(enteredMoney);
                            if (value)
                            {
                                CustomerBill += enteredMoney;
                                if (CustomerBill == p3.Price)
                                {
                                    Console.WriteLine("amount received. Please collect the product from vending machine");
                                }
                                else if (CustomerBill > p3.Price)
                                {
                                    balance = CustomerBill - p3.Price;
                                    Console.WriteLine("please collect the remaining balance and the product");
                                    Console.WriteLine("balance amount:" + balance);
                                    break;
                                }
                                else
                                {
                                    balance = p3.Price - CustomerBill;
                                    Console.WriteLine("please insert balance money to buy the product");
                                    Console.WriteLine("balance amount:" + balance);


                                }
                            }
                            else
                            {
                                //Console.WriteLine("coin is not valid. please insert the valid coins. valid coins are :" + c1.coinValue + "," + c2.coinValue + "," + c3.coinValue);
                                Console.WriteLine("coin is not valid. please insert the valid coins.");
                            }

                        }

                        break;
                    default:
                        Console.WriteLine("your selection is invalid");
                        break;

                }
                Console.WriteLine("Thank you for using the vending machine");
                Console.WriteLine("Press any key to continue.....");
            } while (Console.ReadLine() != null);
            
            
            Console.WriteLine("Thank you for using the vending machine");
        }

        public static bool ValidateEnteredMoney(double enteredMoney)
        {
            try
            {
                Coin c1 = new Coin(0.05);
                Coin c2 = new Coin(0.01);
                Coin c3 = new Coin(0.25);
                List<double> ValidMoneyList = new List<double>();
                ValidMoneyList.Add(c1.coinValue);
                ValidMoneyList.Add(c2.coinValue);
                ValidMoneyList.Add(c3.coinValue);
                if (ValidMoneyList.Contains(enteredMoney))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
