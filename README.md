# Meta Quest 3 Development with Unity
## Recommended Software
- **Unity Hub** ([Windows](https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe) | [macOS](https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.dmg))
  - Manages Unity installs and Unity projects
- **Unity 2022 LTS**
  - Installed via Unity Hub
  - Use the latest 2022 LTS version
  - Make sure to include the following modules with the install:
    - Android Build Support
    - OpenJDK
    - Android SDK & NDK Tools
- **Oculus Integration for Unity**
  - SDK and plugin providing the Meta OVR abstraction layer and Unity helpers to make OpenXR development more streamlined
  - Includes Meta XR Simulator
    - Simulates headsets and mixed reality environments to enable development without a device to test on
    - [Guide for Unity](https://developer.oculus.com/documentation/unity/xrsim-unity)
  - Two ways to import into Unity
    - Add package to your account in the [Unity Asset Store](https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022) and then import via “My Assets” in Package Manager
    - Download [Unity Package](https://developer.oculus.com/downloads/package/unity-integration/) from Meta and import into Unity project via Assets>Import Package>Custom Package
    - [More info](https://developer.oculus.com/documentation/unity/unity-import/)
- **Meta Quest Developer Hub (MQDH)** ([Windows](https://developer.oculus.com/downloads/package/oculus-developer-hub-win/) | [macOS](https://developer.oculus.com/downloads/package/oculus-developer-hub-mac/))
  - Suite of tools for Quest development (performance analysis, headset management, SDKs for Quest features, code samples, local multiplayer, etc.)
  - [More info](https://developer.oculus.com/meta-quest-developer-hub)
- Meta Quest Mobile app
  - Required for initial setup, but also enables screen casting & recording from the headset to your phone
  - Android and iOS app stores

## Development Guide
- Meta documentation for [Quest Development in Unity](https://developer.oculus.com/documentation/unity/unity-gs-overview/)
- Guide on [Setting up Your First Quest App](https://developer.oculus.com/documentation/unity/unity-tutorial-hello-vr/)
  - Helpful to understand the myriad specific settings required to build and run a game on the Quest
- Once comfortable with app setup, dive into examples:
  - Example scenes included with the Oculus Integration for Unity
    - Available in Assets>Oculus>VR>Scenes after package is installed
  - MQDH Code Samples (under the “Code Samples” tab in the “Downloads” section)
