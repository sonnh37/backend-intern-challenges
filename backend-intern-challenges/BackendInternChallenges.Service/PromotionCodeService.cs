using BackendInternChallenges.Domain.Contracts.Services;

namespace BackendInternChallenges.Service;

public class PromotionCodeService : IPromotionCodeService
{
    private readonly string _campaignPath;
    private readonly string _membershipPath;

    public PromotionCodeService(string campaignPath, string membershipPath)
    {
        _campaignPath = campaignPath;
        _membershipPath = membershipPath;
    }

    public bool IsEligible(string code)
    {
        if (!IsValidCode(code))
            return false;
        
        if (!ExistsInFile(_campaignPath, code))
            return false;

        return ExistsInFile(_membershipPath, code);
    }

    private bool ExistsInFile(string path, string code)
    {
        foreach (var line in File.ReadLines(path))
        {
            if (line == code)
                return true;
        }
        return false;
    }
    
    private static bool IsValidCode(string code)
    {
        if (string.IsNullOrEmpty(code))
            return false;

        if (code.Length < 1 || code.Length > 5)
            return false;

        foreach (char c in code)
        {
            if (c < 'a' || c > 'z')
                return false;
        }

        return true;
    }
}