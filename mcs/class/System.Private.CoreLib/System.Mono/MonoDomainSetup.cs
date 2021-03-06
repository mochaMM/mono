using System.Runtime.InteropServices;

namespace System.Mono
{
	[StructLayout (LayoutKind.Sequential)]
	internal sealed class MonoDomainSetup
	{
		string application_base;
		string application_name;
		string cache_path;
		string configuration_file;
		string dynamic_base;
		string license_file;
		string private_bin_path;
		string private_bin_path_probe;
		string shadow_copy_directories;
		string shadow_copy_files;
		bool publisher_policy;
		private bool path_changed;
		private int loader_optimization;
		bool disallow_binding_redirects;
		bool disallow_code_downloads;

		object _activationArguments;
		object domain_initializer;
		object application_trust;
		string [] domain_initializer_args;

		bool disallow_appbase_probe;
		byte [] configuration_bytes;

		byte [] serialized_non_primitives;

		public MonoDomainSetup ()
		{
		}
	}
}
