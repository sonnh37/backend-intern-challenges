namespace BackendInternChallenges.Domain.Contracts.Services;

public interface IPromotionCodeService
{
    bool IsEligible(string code);
}