<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
    <ProduceAssemblyReference>true</ProduceAssemblyReference>
  </PropertyGroup>

  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|AnyCPU'">
    <DebugType>pdbonly</DebugType>
    <DebugSymbols>true</DebugSymbols>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Xamarin.Forms" Version="4.0.0.62955-pre2" />
    <PackageReference Include="ZXing.Net.Mobile" Version="2.4.1" />
    <PackageReference Include="ZXing.Net.Mobile.Forms" Version="2.4.1" />  
  </ItemGroup>

  <ItemGroup>
    <Compile Update="Views\SearchItemPage.xaml.cs">
      <DependentUpon>SearchItemPage.xaml</DependentUpon>
    </Compile>
  </ItemGroup>
</Project>