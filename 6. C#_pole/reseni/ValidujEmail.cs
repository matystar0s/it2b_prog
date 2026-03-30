class Program
{
    static bool ValidujEmail(string email)
    {
        if (email[0] == '@')
        {
            return false;
        }

        int pozice = -1;

        for (int i = 0; i < email.Length; i++)
        {
            if (email[i] == '@')
            {
                if (pozice > 0) {
                    return false;
                }
                pozice = i;
            }
        }

        for (int i = pozice + 1; i < email.Length; i++)
        {
            if (email[i] == '.')
                return true;
        }
        return false;
    }

    static void Main()
    {
    }
}
