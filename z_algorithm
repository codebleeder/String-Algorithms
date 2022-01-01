public static List<int> GetZArr(string s)
{
    var z = new int[s.Length];
    z[0] = 0;
    var left = 0;
    var right = 0;
    for (var i = 1; i < s.Length; ++i)
    {
        // if outside yellow box - brute force
        if (i > right)
        {
            left = right = i;
            while (right < s.Length && s[right - left] == s[right])
            {
                ++right;
            }
            z[i] = right - left;
            --right;
        }

        else
        {
            var i1 = i - left;
            // if strictly inside yellow box - copy the answer 
            if (z[i1] < right - i + 1)
            {
                z[i] = z[i1];
            }
            // if touching the yellow boundary or exceeding the boundary
            // reset left and try to get more matches 
            else
            {
                left = i;
                while (right < s.Length && s[right] == s[right - left])
                {
                    ++right;
                }
                z[i] = right - left;
                --right;
            }
        }
    }
    return new List<int>(z);
}
