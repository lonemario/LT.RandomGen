﻿using LT.RandomGen.Data;
using LT.RandomGen.Data.Animals;
using LT.RandomGen.Data.Foods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LT.RandomGen
{
    public static class RandomGenerator
    {
        private static Random random = new Random();

        /// <summary>
        /// Get the list of words by kind and Language
        /// </summary>
        /// <param name="Kind"></param>
        /// <param name="Language"></param>
        /// <returns></returns>
        internal static List<string> GetWords(Kinds Kind, Languages Language)
        {
            switch (Language)
            {
                case Languages.English:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return EnAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return EnFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Croatian:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return HrAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return HrFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Czech:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return CsAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return CsFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Danish:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return DaAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return DaFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Dutch:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return NlAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return NlFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Estonian:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return EtAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return EtFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Finnish:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return FiAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return FiFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.French:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return FrAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return FrFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.German:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return DeAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return DeFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Hungarian:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return HuAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return HuFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Irish:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return GaAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return GaFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Italian:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return ItAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return ItFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Latin:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return LaAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return LaFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Polish:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return PlAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return PlFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Portuguese:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return PtAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return PtFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Slovak:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return SkAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return SkFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Slovene:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return SlAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return SlFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Spanish:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return EsAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return EsFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                case Languages.Swedish:
                    switch (Kind)
                    {
                        case Kinds.Animals:
                            return SvAnimals.GetAnimals();
                            break;
                        case Kinds.Foods:
                            return SvFoods.GetFoods();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }

        /// <summary>
        /// Return the separator caracter between blank, comma or dot
        /// </summary>
        /// <returns></returns>
        internal static string GetSeparator()
        {
            var r = random.Next(0, 9);

            if (r == 9)
                return ". ";

            if (r > 5)
                return ", ";

            return " ";
        }

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

        /// <summary>
        /// Return a text 
        /// </summary>
        /// <param name="Kind"></param>
        /// <param name="WordsNumber"></param>
        /// <param name="Language"></param>
        /// <param name="UseSeparatorLogic"></param>
        /// <returns></returns>
        public static string GenerateText(Kinds Kind, int? WordsNumber = null, Languages Language = Languages.English,
                                            bool UseSeparatorLogic = true )
        {
            //Se il numero di parole è negativo torno vuoto
            if (WordsNumber.HasValue)
                if (WordsNumber.Value < 0)
                    return "";

            //Recupero le parole
            var words = GetWords(Kind, Language);

            //torno tutte le parole
            if (WordsNumber == null)
                if (UseSeparatorLogic)
                {
                    string resp = String.Empty;
                    foreach (var word in words)
                    {
                        if (resp!=String.Empty)
                        {
                            resp = resp + GetSeparator() + word;
                        }
                        else
                        {
                            //primo passaggio, non metto il separatore
                            resp = resp + word;
                        }
                    }
                    return resp;
                }
                else
                {
                    return string.Join(" ", words.ToArray());
                }

            //Torno il numero di parole specificato
            if (UseSeparatorLogic)
            {
                string resp = String.Empty;
                for (int i = 0; i < WordsNumber; i++)
                {
                    if (resp != String.Empty)
                    {
                        resp = resp + GetSeparator() + words[random.Next(0,words.Count-1)];
                    }
                    else
                    {
                        //primo passaggio, non metto il separatore
                        resp = resp + words[random.Next(0, words.Count - 1)];
                    }
                }
                return resp;
            }
            else
            {
                string resp = String.Empty;
                for (int i = 0; i < WordsNumber; i++)
                {
                    resp = resp + words[random.Next(0, words.Count - 1)] + " ";
                }
                return resp;
            }

        }

        public static string GenerateParagraphs(Kinds Kind, int ParagraphsNumber, Languages Language = Languages.English)
        {
            //Se il numero di paragrafi è minore di 1 torno vuoto
            if (ParagraphsNumber < 1)
                return "";

            int minWordsInParagraph = 70;
            int maxWordsInParagraph = 110;

            string resp = String.Empty;
            for (int i = 0; i < ParagraphsNumber; i++)
            {
                if (resp != String.Empty)
                {
                    resp = resp + Environment.NewLine + Environment.NewLine + GenerateText(Kind, 
                        random.Next(minWordsInParagraph, maxWordsInParagraph), Language);
                }
                else
                {
                    //primo passaggio, non metto il separatore
                    resp = resp + GenerateText(Kind, random.Next(minWordsInParagraph, maxWordsInParagraph), Language);
                }
            }
            return resp;
        }
    }
}
