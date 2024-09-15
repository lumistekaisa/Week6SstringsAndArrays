
string userName = "Darth Vader";

Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Length - 1]}.");


//replace
//a - 4

string updatedUserName = userName.Replace('a', '4').Replace('r', '2');

Console.WriteLine(updatedUserName);





//a-counter

//int counter = 0;

//for(int i = 0; i < userName.Length; i++)
//{
//    if (userName[i] == 'a')
//    {
//        counter++; //counter = counter + 1
//    }
//}

//Console.WriteLine($"Your name has {counter} a-letters.");



//Console.WriteLine(userName[0]);
//Console.WriteLine(userName[1]);
//Console.WriteLine(userName[2]);
//Console.WriteLine(userName[3]);
//Console.WriteLine(userName[4]);