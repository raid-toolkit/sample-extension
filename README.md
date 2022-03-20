# Sample Raid Toolkit extension

This sample illustrates how to:

- [ ] Add custom UI
- [ ] Add a background service
- [ ] Access and update when the current game view changes

## Building and running the sample

This sample uses the MSBuild integration supplied by `Raid.Toolkit.Extensibility.Tasks`. This requires a manifest JSON file with `RTKExtensionManifest` set as its `BuildAction`. This provides the build tooling all the information required to generate a valid RTK extension DLL.

This project is already configured to copy the output extension to `%USERPROFILE%\AppData\Local\RaidToolkit\Extensions` which will be automatically loaded whenever RTK is started.

To test your extension, simply:

1. Exit RTK (to release any lock on a previous build)
2. Build the solution in VS/VSCode
3. Restart RTK
4. Profit! Your extension should now be loaded!

### Manifest

The `.rtk.extension.json` file contains a manifest that describes your extension as well as list of types required by your extension to run.

> To discover which types you want to generate code for, use a tool like `il2cppdumper` to browse the full set of classes available.

### Extension Package

The entrypoint for any extension is an implementation of `IExtensionPackage`. This interface provides access to the basic lifecycle events for any extension loaded into RTK.
