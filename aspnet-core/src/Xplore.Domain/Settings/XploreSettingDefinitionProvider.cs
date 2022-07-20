using Volo.Abp.Settings;

namespace Xplore.Settings;

public class XploreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(XploreSettings.MySetting1));
    }
}
