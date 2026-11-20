namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region short hand if
            //int age = 15;

            //if (age < 20)
            //{
            //    Console.WriteLine("teen");
            //}
            //else
            //{
            //    Console.WriteLine("adult");
            //}            

            ////               condition   true       false 
            //string result = (age < 20) ? "teen" : "adult";
            //Console.WriteLine(result);

            #endregion

            #region switch
            // check equality (item = case) => code 
            //char grade = 'A';                 //0 ,1,2,3,4
            //switch (grade) //jump statement ('A','B','C',_) equality 
            //{
            //    case 'A': //true
            //        Console.WriteLine("Excellent"); // no
            //        break;
            //    case 'B':
            //        Console.WriteLine("Very Good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("Good");
            //        break;


            //    default:
            //        Console.WriteLine("fail");
            //        break; //else If ledder ==> all cases are false 
            //}


            //short hand switch
            //char grade = 'A';
            //string result2 = grade switch
            //{
            //    'A' or 'B' =>"Excellent",
            //    'C'=>"Good",
            //    'D'=>"Pass",
            //    _ => "invalide"
            //};
            //Console.WriteLine(result2);


            #endregion


            //control statement =>Total code => codition => looping => jumping
            //contional statement => if ...if_else ...if _else If _else ...switch

            #region looping statements
            // repeate code =>loop 
            //for ...foreach
            //while ...do_while 
            //0  1    2   3
            //int[] numbers = { 10, 20, 30, 40 };

            #region for statement 
            //int x = 10;
            //for (int i=0; i < numbers.Length;i++) // access items 
            //{
            //    Console.WriteLine($"iteration number {i+1} and x = {x* i}");
            //}
            //// print to the values .... access to the values ...override ...update 
            //#endregion


            //#region foreach
            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num + 10);
            //}




            #endregion


            #region  while 
            //number of iteration 
            //int index = 0;
            //while(index < numbers.Length) //false => out of the block 
            //{
            //    Console.WriteLine(numbers[index]);
            //    index++; //without it => infinty loop 
            //}

            #endregion


            #region  do ... while 

            // access 1 time to run the code 
            //int count = 0;
            //do
            //{
            //    Console.WriteLine("your count is " + count); // iti 1 => count 0 iti 02 count =1 
            //    count++;//count =1  count = 2

            //} while (count < 2); //count =1 count = 2 false => out of the block 








            #endregion

            #endregion

            #region jumping statement 
            // out of a block     change the point    skipe to code    ignore to code 
            //4 keywords 
            // break .... continue .... Goto....return 

            #region break
            //for ...switch 
            //out of the block

            #endregion

            #region continue 
            //for (int i = 0; i < 10; i++) //0 1 2 3 4
            //{
            //    if (i == 3) continue; //3 true 

            //    Console.WriteLine(i);//0 1 2 4


            //}



            #endregion

            #region return 
            // inside function & methods 
            //int c= print();
            //Console.WriteLine(c);

            #endregion

            #region Goto 
            //int x = 10;
            //int y = 20;

            //int result = x + y;
            //goto checked;

            ////Console.WriteLine(result);
            //// spagitty code = reduce performance 
            //checked
            //{
            //    x = y;
            //    Console.WriteLine(x);
            //}


            #endregion

            #endregion

        }

        public static int print() {  
            int x = 5;
            int y = 10;
            int result = x + y;
            return result; //jump out of method 
            x++;
            result = 1000;
        
        }
    }
}
