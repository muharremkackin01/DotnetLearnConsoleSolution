/*
 * Veri Turleri
 * **/

// var

using System.Runtime.CompilerServices;

var name = "muharrem";

// String - Yazi veri turu

string username = "RedParasite74";
string password = "1234567";
string title = "Dotnet Ogreniyorum";

// Integer - Sayi veri turu

int hp = 150;
int now_year = DateTime.Now.Year;

// Boolean

bool is_logged_in = true;
bool is_logged_out = !is_logged_in;


// IF ELSE - IF ELSE IF ELSE

//Console.WriteLine("Write your User Name");
//var _username = Console.ReadLine();
//Console.WriteLine("Write your Password");
//var _password = Console.ReadLine();

//if (_username == string.Empty || _password == "")
//{
//    Console.WriteLine("Kullanici ya da sifre bos birakilamaz!");
//}
//else
//{
//    if (_username == username && _password == password)
//    {
//        Console.WriteLine("Hello, " + username);
//    }
//    else
//    {
//        Console.WriteLine("Kullanici adi ya da sifre yanlis!");
//    }
//}

var age = 18;
/**
 * Boolean Operators
 * Equals  ==
 * Not Equal !=
 * Greater >
 * GreaterAndEqual >=
 * Less <
 * LessAndEqual <=
 * */

if (age < 18)
{
    Console.WriteLine("You shall not pass!");
}
else
{
    Console.WriteLine("Go look some girls dude!");
}