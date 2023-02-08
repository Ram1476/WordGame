using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    internal class WrdGame
    {
        
        public char[] given_Word = { 'M', 'A', 'S', 'T', 'E', 'R' };
        public int Score = 0;
        public string[] possibleFormation = { "armets", "maters", "matres", "ramets", "stream", "tamers","armet","aster","mares","marse","marts","maser","mater"
                ,"mates","meats","ramet","rates","reams","resat","satem","smart","smear","stare","steam","tamer","tames","tares","teams","tears","terms","trams",
                "ares","arms","arts","ates","ears","east","eats","eras","erst","etas","maes","mare","mars","mart","mast","mate","mats","meat","mesa","meta","rams","rase","rate","rats","ream","rems","rest","rets","same","sate",
                "seam","sear","seat","sera","seta","star","stem","tame","tams","tare","tars","team","tear","teas","term","tram","tres","tsar","are","arm","ars","art","ate",
                "ear","eat","ems","era","ers","eta","mae","mar","mas","mat","met","ram","ras","rat","rem","res","ret","sae","sat","sea","ser","set","tae","tam","tar","tas","tea","ae","am","ar","as","at","em","er",
                "es","et","ma","me","re","ta"};
        public void Gamerules()
        {
            Console.WriteLine("******* GAME INSTRUCTIONS *******");
            Console.WriteLine("\n* Create Multiple Words from the Letters of the Word \'MASTER\'");
            Console.WriteLine("\n* Don't Repeate the Same Again");
            Console.WriteLine("\n* Enter Quit if you want to end the Game");
            Console.WriteLine("\n* Your Score will be Displayed once you Quit the Game");
            
        }
        public string Startgme()
        {
 
            int i = 1;
            List<string> given_Input = new List<string>();

            while (i > 0) 
            {
                Console.Write("\nEnter your word here: ");
                String user_Input = Console.ReadLine();
                

                string change_Input = user_Input.ToLower();

                if (change_Input != "quit")
                {
                    if (!(given_Input.Contains(change_Input)))
                    {
                        

                            if ( possibleFormation.Contains(change_Input))
                            {
                                Console.WriteLine("-- You Have Entered a Correct Word -- ");
                                given_Input.Add(change_Input);
                                Score++;

                            }
                            else
                            {
                                Console.WriteLine("INCORRECT - Please Provide a Valid Input");

                            }
                        
                    }
                    else 
                    {
                        Console.WriteLine("------You Have Already Found This Word, Try a New Word------");
                    }
                }
                else
                {
                    i = 0;
                }
            }
                return $"Thank you for playing , Your Score is {Score}";
        }


    }
}


