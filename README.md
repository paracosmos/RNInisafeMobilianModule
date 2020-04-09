
# R

# react-native-native-test-library

## Getting started

`$ npm install react-native-native-test-library --save`

### Mostly automatic installation

`$ react-native link react-native-native-test-library`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-native-test-library` and add `RNNativeTestLibrary.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNNativeTestLibrary.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNNativeTestLibraryPackage;` to the imports at the top of the file
  - Add `new RNNativeTestLibraryPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-native-test-library'
  	project(':react-native-native-test-library').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-native-test-library/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-native-test-library')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNNativeTestLibrary.sln` in `node_modules/react-native-native-test-library/windows/RNNativeTestLibrary.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Native.Test.Library.RNNativeTestLibrary;` to the usings at the top of the file
  - Add `new RNNativeTestLibraryPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNNativeTestLibrary from 'react-native-native-test-library';

// TODO: What to do with the module?
RNNativeTestLibrary;
```
