namespace ntrinity
{
public struct RealmBuildInfo
{
private int _Build;
private int _MajorVersion;
private int _MinorVersion;
private int _BugfixVersion;
private int _HotfixVersion;

public RealmBuildInfo(int build, int major, int minor, int bugfix, int hotfix)
{
this.Build = build;
this.MajorVersion = major;
this.MinorVersion = minor;
this.HotfixVersion = hotfix;
}
