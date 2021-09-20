# CustomResourceDesigner

Example of making a "slimmer" Resource.designer.cs

## What's the issue here?

As seen in [xamarin-android#6306](https://github.com/xamarin/xamarin-android/pull/6306),
in a Xamarin.Android class library:

* Include AndroidX & Google Material
* Include at least one `@(AndroidResource)` and use the ID from C#.
* `Resource.designer.cs` has 2,700+ fields

So a pattern to workaround this issue:

1. After a build, copy `obj\Debug\Resource.designer.cs` to your project.
1. Delete every field you don't use.
1. Set: `<AndroidGenerateResourceDesigner>false</AndroidGenerateResourceDesigner>`

This should achieve the desired result of removing the unnecessary 2,700 fields.

If you need to update the manual `Resource.designer.cs` file in the
future, you can simply repeat the steps and include the new fields.