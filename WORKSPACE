workspace(
    name = "repro",
    managed_directories = {"@npm": ["node_modules"]},
)

load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")

git_repository(
    name = "io_bazel_rules_dotnet",
    commit = "e6415707f7e26756456d2473b9b22dfbeff66171",
    remote = "https://github.com/bazelbuild/rules_dotnet",
)

load("@io_bazel_rules_dotnet//dotnet:deps.bzl", "dotnet_repositories")
dotnet_repositories()

load(
    "@io_bazel_rules_dotnet//dotnet:defs.bzl",
    "DEFAULT_DOTNET_CORE_FRAMEWORK",
    "DOTNET_CORE_FRAMEWORKS",
    "DOTNET_NET_FRAMEWORKS",
    "core_register_sdk",
    "dotnet_nuget_new",
    "dotnet_register_toolchains",
    "dotnet_repositories_nugets",
    "mono_register_sdk",
    "net_gac4",
    "net_register_sdk",
    "nuget_package",
)

dotnet_register_toolchains()
dotnet_repositories_nugets()
core_register_sdk(
    DEFAULT_DOTNET_CORE_FRAMEWORK,
)
core_register_sdk(
    DEFAULT_DOTNET_CORE_FRAMEWORK,
    name = "core_sdk",
)

# load NUGET deps
load("//:NUGET.bzl", "project_dotnet_repositories_nuget")      
project_dotnet_repositories_nuget()
