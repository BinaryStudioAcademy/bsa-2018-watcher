using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Enums
{
    [ExportEnumToTypescript]
    public enum OrganizationInviteState
    {
        Pending,
        Accepted,
        Declined,
        Overdue,
        Canceled
    }
}
