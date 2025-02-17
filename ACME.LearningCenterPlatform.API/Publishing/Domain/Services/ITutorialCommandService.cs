using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregate;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Services;

public interface ITutorialCommandService
{
    Task<Tutorial?> Handle(AddVideoAssetToTutorialCommand command);
    Task<Tutorial?> Handle(CreateTutorialCommand command);
}