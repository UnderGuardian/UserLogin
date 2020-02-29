using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

 class Program {
   public static void Main(string[] args) {
     Person Obj = new Person();
     string name;
     string race;
     int age;
     int lvl;
     string rank;
     string class_;
     string gender;
     string aptitudes;
     bool finishRegister = false;
     string Answer;
     do{
      //Name
      Console.WriteLine("Write your name: ");
      Obj.Name = Console.ReadLine();
     
      //Race
      Console.WriteLine("Write your race: ");
      Obj.Race = Console.ReadLine();

      //Age
      Console.WriteLine("Write your age: ");
      Obj.Age = Convert.ToInt32(Console.ReadLine());

      //Lvl
      Console.WriteLine("Write your actual level: ");
      Obj.Lvl = Convert.ToInt32(Console.ReadLine());

      //Rank
      Console.WriteLine("Write your actual rank: ");
      Obj.Rank = Console.ReadLine();

      //Class
      Console.WriteLine("Write your class: ");
      Obj.Class = Console.ReadLine();

      //Gender
      Console.WriteLine("Write your gender: ");
      Obj.Gender = Console.ReadLine();

      //Aptitudes
      Console.WriteLine("Write your aptitudes: ");
      Obj.Aptitudes = Console.ReadLine();

      //Finish Register
      Console.WriteLine("Are the information right?");
      Answer = Console.ReadLine();
      if (Answer == "Yes"|| Answer == "yes"){
        finishRegister = true;
      } else if(Answer == "No" || Answer == "no"){
      finishRegister = false;
     };

     } while (finishRegister != true);

      if(finishRegister == true){      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("\nHere is ur info: ");
      Console.ResetColor();
      
        name = Obj.Name;
        race = Obj.Race;
        age = Obj.Age;
        lvl = Obj.Lvl;
        rank = Obj.Rank;
        class_ = Obj.Class;
        gender = Obj.Gender;
        aptitudes = Obj.Aptitudes;
      
      string Data = "Name: " + name + "\n" + "Race: " + race + "\n" + "Age: " + age + "\n" + "Lvl: " + lvl + "\n" + "Rank: " + rank + "\n" + "Class: " + class_ + "\n" + "Gender: " + gender + "\n" + "Aptitudes: " + aptitudes + " & Null";

    Console.WriteLine(Data);
      };
  }
 }