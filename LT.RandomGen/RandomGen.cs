using System;
using System.Linq;

namespace LT.RandomGen
{
    public static class RandomGenerator
    {
        private static Random random = new Random();
        /// <summary>
        /// Return a random string
        /// </summary>
        /// <param name="length">length of the returned string</param>
        /// <param name="NullPercentage">Percentage of null string 0=never 100=always</param>
        /// <param name="Dynamic">if true the length of the string is dynamic but never greater of setted lenght</param>
        /// <returns></returns>
        public static string GenericString(int length, int NullPercentage = 0, bool Dynamic = true)
        {
            int MaxLength = length;
            if (Dynamic)
            {
                MaxLength = random.Next(0, length);
            }

            if (random.Next(0, 99) < NullPercentage)
            {
                return null;
            }
            else
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789,.-;:_òàùç°§@#[]é*è+\\|!£$%&/()=?^'ì\"";
                return new string(Enumerable.Repeat(chars, MaxLength)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }

        /// <summary>
        /// Return a only Alphanumeric random string 
        /// </summary>
        /// <param name="length">length of the returned string</param>
        /// <param name="NullPercentage">Percentage of null string 0=never 100=always</param>
        /// <param name="Dynamic">if true the length of the string is dynamic but never greater of setted lenght</param>
        /// <returns></returns>
        public static string GenericOnlyAlfaNumericString(int length, int NullPercentage = 0, bool Dynamic = true)
        {
            int MaxLength = length;
            if (Dynamic)
            {
                MaxLength = random.Next(0, length);
            }

            if (random.Next(0, 99) < NullPercentage)
            {
                return null;
            }
            else
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                return new string(Enumerable.Repeat(chars, MaxLength)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }

        /// <summary>
        /// Return a random datetime
        /// </summary>
        /// <returns></returns>
        public static DateTime GenericDate()
        {
            DateTime start = new DateTime(2018, 1, 1);
            int range = (DateTime.Today - start).Days;
            if (range < 1)
            {
                int res = random.Next(range * -1);
                return start.AddDays(res * -1);
            }
            else
            {

            }
            return start.AddDays(random.Next(range));
        }

        /// <summary>
        /// Return a random datetime
        /// </summary>
        /// <param name="NullPercentage">Percentage of null string 0=never 100=always</param>
        /// <returns></returns>
        public static DateTime? GenericNullableDate(int NullPercentage = 0)
        {
            if (random.Next(0, 99) < NullPercentage)
            {
                return null;
            }
            else
            {
                return new DateTime?(GenericDate());
            }
        }

        /// <summary>
        /// Return a random int
        /// </summary>
        /// <param name="MaxValue">Max Value</param>
        /// <param name="MinValue">Possible Minimum Value, default 0</param>
        /// <returns></returns>
        public static int GenericInt(int MaxValue, int MinValue = 0)
        {
            return random.Next(MinValue, MaxValue);
        }

        /// <summary>
        /// Return positive random int with possible null
        /// </summary>
        /// <param name="MaxValue">Max Value</param>
        /// <param name="MinValue">Possible Minimum Value, default 0</param>
        /// <param name="NullPercentage">Percentage of null string 0=never 100=always</param>
        /// <returns></returns>
        public static int? GenericNullableInt(int MaxValue, int MinValue = 0, int NullPercentage = 0)
        {
            if (random.Next(0, 99) < NullPercentage)
            {
                return null;
            }
            else
            {
                return new int?(GenericInt(MaxValue, MinValue));
            }
        }

        /// <summary>
        /// Return a random email address
        /// </summary>
        /// <param name="NullPercentage">Percentage of null email 0=never 100=always</param>
        /// <param name="ValidEmailFormatPercentage">Percentage of valid email format 0=never 100=always</param>
        /// <returns></returns>
        public static string GenericEmail(int NullPercentage = 0, int ValidEmailFormatPercentage = 100)
        {
            if (random.Next(0, 99) < NullPercentage)
            {
                return null;
            }
            else
            {
                if (random.Next(0, 99) < ValidEmailFormatPercentage)
                {
                    //TORNA EMAIL SICURAMENTE VALIDA
                    var res = GenericOnlyAlfaNumericString(50, NullPercentage);
                    if (res != null)
                    {
                        switch (random.Next(0, 4))
                        {
                            case 1:
                                return res + "@yahoo.it";
                                break;
                            case 2:
                                return res + "@hotmail.com";
                                break;
                            case 3:
                                return res + "@libero.it";
                                break;
                            case 4:
                                return res + "@outlook.com";
                                break;
                            case 0:
                            default:
                                return res + "@gmail.com";
                                break;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    //TORNA EMAIL ANCHE NON VALIDA
                    var res = GenericString(15, NullPercentage);
                    if (res != null)
                    {
                        int Meta = res.Length / 2;
                        string nome = res.Substring(0, Meta);
                        string dominio = res.Substring(Meta, Meta);
                        return nome + "@" + dominio + "." + GenericString(2, 0, false);
                    }
                    else
                    {
                        return null;
                    }
                }

            }
        }
    }
}
