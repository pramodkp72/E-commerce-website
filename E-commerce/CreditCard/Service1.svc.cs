using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CreditCard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // Here we are using Luhn's algorithm to validate real time credit cards and debit cards.
        public bool creditCardVerification(string source)
        {
            
                // We take the input as a string and convert it into a integer array
                // string source = "4766430501599323";
                int[] digits = new int[source.Length];
                for (int i = 0; i < source.Length; i++)
                {
                    digits[i] = Convert.ToInt32(source.Substring(i, 1));
                }

                // We double every second number in the array from the last but one element
                for (int i = digits.Length - 2; i >= 0; i = i - 2)
                {
                    int current = digits[i] * 2;
                    if (current > 9)
                    {
                        current = current - 9;
                        digits[i] = current;
                        //  Console.WriteLine(current);
                    }
                    // we leave the other elements as it is
                    else
                    {
                        digits[i] = current;
                    }
                }
                int sum = 0;
                // We find the sum of the elements in the array
                for (int i = 0; i < digits.Length; i++)
                {
                    sum += digits[i];
                }

                //If the sum is perfectly divisible by 10 then the card is valid or else it is not.
                if (sum % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

    
    }

