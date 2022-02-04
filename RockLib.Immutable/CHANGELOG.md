# RockLib.Immutable Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## 2.0.0 - 2022-02-04

#### Added
- Added `.editorconfig` and `Directory.Build.props` files to ensure consistency.

#### Changed
- Supported targets: net6.0, netcoreapp3.1, and net48.
- As the package now uses nullable reference types, some method parameters now specify if they can accept nullable values.
- Since we no longer target .NET 3.5, the `Lazy` class file was deleted.

## 1.0.7 - 2021-08-10

#### Changed

- Changes "Quicken Loans" to "Rocket Mortgage".
- Updates RockLib.Threading to latest version, [1.0.6](https://github.com/RockLib/RockLib.Threading/blob/main/RockLib.Threading/CHANGELOG.md#106---2021-08-09).

## 1.0.6 - 2021-05-06

#### Added

- Adds SourceLink to nuget package.

#### Changed

- Updates RockLib.Threading package to latest version, which includes SourceLink.

----

**Note:** Release notes in the above format are not available for earlier versions of
RockLib.Immutable. What follows below are the original release notes.

----

## 1.0.4

Adds net5.0 target.

## 1.0.3

Adds icon to project and nuget package.

## 1.0.2

Updates to align with nuget conventions.

## 1.0.1

Adds support for .NET Framework 3.5 and 4.0.

## 1.0.0

Initial release, contains NamedCollection<T> class.
