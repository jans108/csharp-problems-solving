using International_Calling_Connoisseur;

var dictionary = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 263, "Zimbabwe");

var longestCountryName = DialingCodes.FindLongestCountryName(dictionary);

Console.WriteLine(longestCountryName);