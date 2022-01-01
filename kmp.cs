public static bool Kmp(string pattern, string s)
{
    var kmpArr = GetKmpArr(pattern);
    var strPtr = 0;
    var patternPtr = 0;
    while(strPtr < s.Length)
    {
        if(patternPtr == pattern.Length)
        {
            return true;
        }
        if(s[strPtr] == pattern[patternPtr])
        {
            ++strPtr;
            ++patternPtr;
        }
        else
        {
            if(patternPtr == 0)
            {
                ++strPtr;
            }
            else if(patternPtr > 0)
            {
                patternPtr = kmpArr[patternPtr - 1];
            }

        }
    }

    return patternPtr == pattern.Length;
}

public static List<int> GetKmpArr(string pattern)
{
    var res = new List<int> { 0 };
    var left = 0;
    var right = 1;
    while(right < pattern.Length)
    {
        if(pattern[left] == pattern[right])
        {
            res.Add(left + 1);
            ++right;
            ++left;
        }
        else if(left == 0)
        {
            res.Add(0);
            ++right;
            ++left;
        }
        else
        {
            left = res[left - 1];
        }
    }
    return res;
}
        
