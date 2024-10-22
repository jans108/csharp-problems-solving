namespace International_Calling_Connoisseur;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new();

    public static Dictionary<int, string> GetExistingDictionary()
    {
        var newDictionary = new Dictionary<int, string>()
        {
            {55, "Brazil" },
            {1, "United States of America" },
            {91, "India" }
        };

        return newDictionary;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var emptyDictionary = new Dictionary<int, string>();

        emptyDictionary[countryCode] = countryName;

        return emptyDictionary;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);

        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        var countryName = string.Empty;

        if (existingDictionary.ContainsKey(countryCode)) 
        countryName = existingDictionary[countryCode];

        return countryName;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode))
            return true;

        return false;
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
            existingDictionary[countryCode] = countryName;

        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);

        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        if (existingDictionary.Count == 0)
            return string.Empty;

        var theBiggestValue = existingDictionary.Values
            .OrderByDescending(n => n.Length)
            .First();

        return theBiggestValue;
    }
}
