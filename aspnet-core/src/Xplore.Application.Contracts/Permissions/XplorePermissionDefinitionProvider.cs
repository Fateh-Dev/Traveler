using Xplore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Xplore.Permissions;

public class XplorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(XplorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(XplorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<XploreResource>(name);
    }
}
