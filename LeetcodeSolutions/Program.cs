using LeetcodeSolutions.Solutions;

Console.WriteLine("** Solution Testing **");

//{ "I", 1 },
//{ "V", 5 },
//{ "X", 10 },
//{ "L", 50 },
//{ "C", 100 },
//{ "D", 500 },
//{ "M", 1000 },

var RomanToInteger = new RomanToInteger();


string case1 = "II";
string case2 = "LVIII";
string case3 = "MCMXCIV";
string max = "MMMCMXCIX";
string case4 = "CMCMCMCMC";


Console.WriteLine(RomanToInteger.RomanToIntV2(case4));