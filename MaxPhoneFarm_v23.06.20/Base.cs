using System;
using System.IO;

internal class Base
{
	internal static string string_0 = D5875C8F();

	internal static string string_1 = "";

	internal static string E696F236 = "https://maxlivestream.com/";

	internal const int int_0 = 70;

	internal const string F8891F89 = "maxphonefarm";

	internal static string string_2 = BD8E591F();

	internal static string string_3 = "";

	internal static Random rd = new Random();

	internal static string string_4 = Common.B537BA12("PGh0bWw+CjxoZWFkPgogICAgPHRpdGxlPnt7dWlkfX0gLSBNaW5Tb2Z0d2FyZTwvdGl0bGU+CiAgICA8bGluayByZWw9InN0eWxlc2hlZXQiIGhyZWY9Imh0dHBzOi8vY2RuanMuY2xvdWRmbGFyZS5jb20vYWpheC9saWJzL2J1bG1hLzAuNy41L2Nzcy9idWxtYS5taW4uY3NzIi8+CiAgICA8bGluayByZWw9InN0eWxlc2hlZXQiIGhyZWY9Imh0dHBzOi8vdW5wa2cuY29tL2J1ZWZ5QDAuNy43L2Rpc3QvYnVlZnkubWluLmNzcyI+CiAgICA8c3R5bGU+CiAgICAgICAgLm1lZGlhLWNvbnRlbnQgaW1nLmxhenkgewogICAgICAgICAgICBtYXJnaW4tcmlnaHQ6IDVweDsKICAgICAgICAgICAgbWFyZ2luLWJvdHRvbTogNXB4OwogICAgICAgIH0KICAgIDwvc3R5bGU+CjwvaGVhZD4KPGJvZHkgY2xhc3M9Imhhcy1iYWNrZ3JvdW5kLWxpZ2h0Ij4KPGRpdiBjbGFzcz0iY29udGFpbmVyIj4KICAgIDxkaXYgaWQ9ImFwcCIgc3R5bGU9InBhZGRpbmctdG9wOiAxNXB4OyI+CiAgICAgICAgPGgxIGNsYXNzPSJ0aXRsZSBpcy0xIGhhcy10ZXh0LWNlbnRlcmVkIj4KICAgICAgICAgICAgPHAgY2xhc3M9Imhhcy10ZXh0LWNlbnRlcmVkIj4KICAgICAgICAgICAgICAgIDxpbWcgc3JjPSJodHRwczovL2dyYXBoLmZhY2Vib29rLmNvbS97e3VpZH19L3BpY3R1cmU/aGVpZ2h0PTE1MCI+CiAgICAgICAgICAgIDwvcD4KICAgICAgICAgICAgPGEgY2xhc3M9Imhhcy10ZXh0LWluZm8iIGhyZWY9Imh0dHBzOi8vd3d3LmZhY2Vib29rLmNvbS97e3VpZH19IiB0YXJnZXQ9Il9ibGFuayI+e3t1aWR9fSAtIHt7bmFtZX19PC9hPgogICAgICAgIDwvaDE+CiAgICAgICAgPGgzIGNsYXNzPSJzdWJ0aXRsZSBpcy0zIGhhcy10ZXh0LWNlbnRlcmVkIj5OZ8OgeSBzaW5oOiB7e2JpcnRoZGF5fX0KICAgICAgICA8L2gzPgoKICAgICAgICA8Yi10YWJzIHBvc2l0aW9uPSJpcy1jZW50ZXJlZCI+CiAgICAgICAgICAgIDxiLXRhYi1pdGVtPgogICAgICAgICAgICAgICAgPHRlbXBsYXRlIHNsb3Q9ImhlYWRlciI+CiAgICAgICAgICAgICAgICAgICAgPHNwYW4gY2xhc3M9Imhhcy10ZXh0LXdpZWdodC1ib2xkIj4gSMOsbmgg4bqibmggPGItdGFnIHR5cGU9ImlzLXdhcm5pbmciCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHJvdW5kZWQ+IHt7IHBob3Rvcy5sZW5ndGggfX0gPC9iLXRhZz4gPC9zcGFuPgogICAgICAgICAgICAgICAgPC90ZW1wbGF0ZT4KICAgICAgICAgICAgICAgIDxkaXYgY2xhc3M9ImZpZWxkIj4KICAgICAgICAgICAgICAgIDx0ZXh0YXJlYSBjbGFzcz0idGV4dGFyZWEiIHYtbW9kZWw9InBob3Rvc0tleXdvcmQiIHJvd3M9IjEwIgogICAgICAgICAgICAgICAgICAgICAgICAgIHBsYWNlaG9sZGVyPSJOaOG6rXAgbeG7l2kgdMOqbiAxIGTDsm5nIMSR4buDIHTDrG0ga2nhur9tIj48L3RleHRhcmVhPgogICAgICAgICAgICAgICAgPC9kaXY+CiAgICAgICAgICAgICAgICA8ZGl2IGNsYXNzPSJmaWVsZCBib3giIHYtZm9yPSJwIGluIHBob3RvcyIgOmtleT0icC51aWQiIHYtc2hvdz0icC5zaG93Ij4KICAgICAgICAgICAgICAgICAgICA8ZGl2IGNsYXNzPSJtZWRpYSI+CiAgICAgICAgICAgICAgICAgICAgICAgIDxkaXYgY2xhc3M9Im1lZGlhLWxlZnQgYm94Ij4KICAgICAgICAgICAgICAgICAgICAgICAgICAgIDxpbWcgY2xhc3M9ImxhenkiIDpkYXRhLXNyYz0iYGh0dHBzOi8vZ3JhcGguZmFjZWJvb2suY29tLyR7cC51aWR9L3BpY3R1cmU/aGVpZ2h0PTE1MGAiPgogICAgICAgICAgICAgICAgICAgICAgICAgICAgPHAgY2xhc3M9Imhhcy10ZXh0LWNlbnRlcmVkIGhhcy10ZXh0LXdpZ2h0LWJvbGQiPgogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIDxhIDpocmVmPSJgaHR0cHM6Ly93d3cuZmFjZWJvb2suY29tLyR7cC51aWR9YCI+e3sgcC5uYW1lIH19PC9hPgogICAgICAgICAgICAgICAgICAgICAgICAgICAgPC9wPgogICAgICAgICAgICAgICAgICAgICAgICA8L2Rpdj4KICAgICAgICAgICAgICAgICAgICAgICAgPGRpdiBjbGFzcz0ibWVkaWEtY29udGVudCI+CiAgICAgICAgICAgICAgICAgICAgICAgICAgICA8ZGl2IGNsYXNzPSJjb250ZW50Ij4KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA8aW1nIGNsYXNzPSJsYXp5IiB2LWZvcj0iKHNyYywgaSkgaW4gcC5waG90b3MiIDpkYXRhLXNyYz0ic3JjIiA6a2V5PSJgJHtwLnVpZH1fJHtpfWAiPgogICAgICAgICAgICAgICAgICAgICAgICAgICAgPC9kaXY+CiAgICAgICAgICAgICAgICAgICAgICAgIDwvZGl2PgogICAgICAgICAgICAgICAgICAgIDwvZGl2PgogICAgICAgICAgICAgICAgPC9kaXY+CiAgICAgICAgICAgIDwvYi10YWItaXRlbT4KICAgICAgICAgICAgPGItdGFiLWl0ZW0+CiAgICAgICAgICAgICAgICA8dGVtcGxhdGUgc2xvdD0iaGVhZGVyIj4KICAgICAgICAgICAgICAgICAgICA8c3BhbiBjbGFzcz0iaGFzLXRleHQtd2llZ2h0LWJvbGQiPiBCw6xuaCBMdeG6rW4gPGItdGFnIHR5cGU9ImlzLXdhcm5pbmciCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICByb3VuZGVkPiB7eyBjb21tZW50cy5sZW5ndGggfX0gPC9iLXRhZz4gPC9zcGFuPgogICAgICAgICAgICAgICAgPC90ZW1wbGF0ZT4KICAgICAgICAgICAgICAgIDxkaXYgY2xhc3M9ImZpZWxkIj4KICAgICAgICAgICAgICAgIDx0ZXh0YXJlYSBjbGFzcz0idGV4dGFyZWEiIHYtbW9kZWw9ImNvbW1lbnRzS2V5d29yZCIgcm93cz0iMTAiCiAgICAgICAgICAgICAgICAgICAgICAgICAgcGxhY2Vob2xkZXI9Ik5o4bqtcCBt4buXaSBiw6xuaCBsdeG6rW4gMSBkw7JuZyDEkeG7gyB0w6xtIGtp4bq/bSI+PC90ZXh0YXJlYT4KICAgICAgICAgICAgICAgIDwvZGl2PgogICAgICAgICAgICAgICAgPGRpdiBjbGFzcz0iZmllbGQiPgogICAgICAgICAgICAgICAgICAgIDx0YWJsZSBjbGFzcz0idGFibGUgaXMtZnVsbHdpZHRoIGlzLWJvcmRlcmVkIGlzLXN0cmlwZWQgaXMtaG92ZXJhYmxlIj4KICAgICAgICAgICAgICAgICAgICAgICAgPHRib2R5PgogICAgICAgICAgICAgICAgICAgICAgICA8dHIgdi1mb3I9IihjLCBpKSBpbiBmaWx0ZXJlZENvbW1lbnRzIiA6a2V5PSJpIj4KICAgICAgICAgICAgICAgICAgICAgICAgICAgIDx0ZCBjbGFzcz0iaXMtbmFycm93Ij57eyBpKzEgfX08L3RkPgogICAgICAgICAgICAgICAgICAgICAgICAgICAgPHRkPnt7IGMgfX08L3RkPgogICAgICAgICAgICAgICAgICAgICAgICA8L3RyPgogICAgICAgICAgICAgICAgICAgICAgICA8L3Rib2R5PgogICAgICAgICAgICAgICAgICAgIDwvdGFibGU+CiAgICAgICAgICAgICAgICA8L2Rpdj4KICAgICAgICAgICAgPC9iLXRhYi1pdGVtPgogICAgICAgICAgICA8Yi10YWItaXRlbT4KICAgICAgICAgICAgICAgIDx0ZW1wbGF0ZSBzbG90PSJoZWFkZXIiPgogICAgICAgICAgICAgICAgICAgIDxzcGFuIGNsYXNzPSJoYXMtdGV4dC13aWVnaHQtYm9sZCI+IFRpbiBOaOG6r24gPGItdGFnIHR5cGU9ImlzLXdhcm5pbmciCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHJvdW5kZWQ+IHt7IG1lc3NhZ2VzLmxlbmd0aCB9fSA8L2ItdGFnPiA8L3NwYW4+CiAgICAgICAgICAgICAgICA8L3RlbXBsYXRlPgogICAgICAgICAgICAgICAgPGRpdiBjbGFzcz0iZmllbGQiPgogICAgICAgICAgICAgICAgPHRleHRhcmVhIGNsYXNzPSJ0ZXh0YXJlYSIgdi1tb2RlbD0ibWVzc2FnZXNLZXl3b3JkIiByb3dzPSIxMCIKICAgICAgICAgICAgICAgICAgICAgICAgICBwbGFjZWhvbGRlcj0iTmjhuq1wIG3hu5dpIHTDqm4gMSBkw7JuZyDEkeG7gyB0w6xtIGtp4bq/bSI+PC90ZXh0YXJlYT4KICAgICAgICAgICAgICAgIDwvZGl2PgogICAgICAgICAgICAgICAgPGRpdiBjbGFzcz0iZmllbGQiPgogICAgICAgICAgICAgICAgICAgIDx0YWJsZSBjbGFzcz0idGFibGUgaXMtZnVsbHdpZHRoIGlzLWJvcmRlcmVkIGlzLXN0cmlwZWQgaXMtaG92ZXJhYmxlIj4KICAgICAgICAgICAgICAgICAgICAgICAgPHRib2R5PgogICAgICAgICAgICAgICAgICAgICAgICA8dHIgdi1mb3I9IihtLCBpKSBpbiBmaWx0ZXJlZE1lc3NhZ2VzIiA6a2V5PSJpIj4KICAgICAgICAgICAgICAgICAgICAgICAgICAgIDx0ZCBjbGFzcz0iaXMtbmFycm93Ij57eyBpKzEgfX08L3RkPgogICAgICAgICAgICAgICAgICAgICAgICAgICAgPHRkPnt7IG0gfX08L3RkPgogICAgICAgICAgICAgICAgICAgICAgICA8L3RyPgogICAgICAgICAgICAgICAgICAgICAgICA8L3Rib2R5PgogICAgICAgICAgICAgICAgICAgIDwvdGFibGU+CiAgICAgICAgICAgICAgICA8L2Rpdj4KICAgICAgICAgICAgPC9iLXRhYi1pdGVtPgogICAgICAgIDwvYi10YWJzPgogICAgPC9kaXY+CjwvZGl2Pgo8c2NyaXB0IHNyYz0iaHR0cHM6Ly9jZG4uanNkZWxpdnIubmV0L25wbS92dWVAMi42LjEwL2Rpc3QvdnVlLmpzIj48L3NjcmlwdD4KPHNjcmlwdCBzcmM9Imh0dHBzOi8vdW5wa2cuY29tL2J1ZWZ5QDAuNy43L2Rpc3QvYnVlZnkubWluLmpzIj48L3NjcmlwdD4KPHNjcmlwdCBzcmM9Imh0dHBzOi8vY2RuLmpzZGVsaXZyLm5ldC9ucG0vdmFuaWxsYS1sYXp5bG9hZEAxMi4wLjAvZGlzdC9sYXp5bG9hZC5taW4uanMiPjwvc2NyaXB0Pgo8c2NyaXB0PgogICAgbGV0IGxhenlMb2FkSW5zdGFuY2UgPSBuZXcgTGF6eUxvYWQoewogICAgICAgIGVsZW1lbnRzX3NlbGVjdG9yOiAiLmxhenkiCiAgICB9KTsKCiAgICBuZXcgVnVlKHsKICAgICAgICBlbDogIiNhcHAiLAogICAgICAgIGRhdGEoKSB7CiAgICAgICAgICAgIHJldHVybiB7CiAgICAgICAgICAgICAgICBjb21tZW50czogW3tjb21tZW50c31dLAogICAgICAgICAgICAgICAgbWVzc2FnZXM6IFt7bWVzc2FnZXN9XSwKICAgICAgICAgICAgICAgIHBob3RvczogW3twaG90b3N9XSwKICAgICAgICAgICAgICAgIGNvbW1lbnRzS2V5d29yZDogIiIsCiAgICAgICAgICAgICAgICBtZXNzYWdlc0tleXdvcmQ6ICIiLAogICAgICAgICAgICAgICAgcGhvdG9zS2V5d29yZDogIiIsCiAgICAgICAgICAgIH0KICAgICAgICB9LAogICAgICAgIG1vdW50ZWQoKSB7CiAgICAgICAgICAgIGxhenlMb2FkSW5zdGFuY2UudXBkYXRlKCk7CiAgICAgICAgICAgIGNvbnNvbGUubG9nKCJ1cGRhdGUiKTsKICAgICAgICB9LAogICAgICAgIHdhdGNoOiB7CiAgICAgICAgICAgIHBob3Rvc0tleXdvcmQobmV3VmFsKXsKICAgICAgICAgICAgICAgIGxldCBsaW5lcyA9IG5ld1ZhbC5zcGxpdCgiXG4iKS5maWx0ZXIoeCA9PiB4LnRyaW0oKSAhPT0gIiIpLm1hcCh4ID0+IHgudHJpbSgpKTsKICAgICAgICAgICAgICAgIGlmIChsaW5lcy5sZW5ndGggPT09IDApIHsKICAgICAgICAgICAgICAgICAgICBmb3IgKGxldCBpID0gMDsgaSA8IHRoaXMucGhvdG9zLmxlbmd0aDsgaSsrKSB7CiAgICAgICAgICAgICAgICAgICAgICAgIHRoaXMucGhvdG9zW2ldLnNob3cgPSB0cnVlOwogICAgICAgICAgICAgICAgICAgIH0KICAgICAgICAgICAgICAgIH0gZWxzZSB7CiAgICAgICAgICAgICAgICAgICAgZm9yIChsZXQgaSA9IDA7IGkgPCB0aGlzLnBob3Rvcy5sZW5ndGg7IGkrKykgewogICAgICAgICAgICAgICAgICAgICAgICBmb3IgKGxldCBqID0gMDsgaiA8IGxpbmVzLmxlbmd0aDsgaisrKSB7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICBpZiAodGhpcy5waG90b3NbaV0ubmFtZS5pbmRleE9mKGxpbmVzW2pdKSA9PT0gLTEpIHsKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB0aGlzLnBob3Rvc1tpXS5zaG93ID0gZmFsc2U7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9IGVsc2UgewogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHRoaXMucGhvdG9zW2ldLnNob3cgPSB0cnVlOwogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGJyZWFrCiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9CiAgICAgICAgICAgICAgICAgICAgICAgIH0KICAgICAgICAgICAgICAgICAgICB9CiAgICAgICAgICAgICAgICB9CiAgICAgICAgICAgIH0KICAgICAgICB9LAogICAgICAgIGNvbXB1dGVkOiB7CiAgICAgICAgICAgIGZpbHRlcmVkUGhvdG9zKCkgewogICAgICAgICAgICAgICAgbGV0IGxpbmVzID0gdGhpcy5waG90b3NLZXl3b3JkLnNwbGl0KCJcbiIpLmZpbHRlcih4ID0+IHgudHJpbSgpICE9PSAiIikubWFwKHggPT4geC50cmltKCkpOwogICAgICAgICAgICAgICAgaWYgKGxpbmVzLmxlbmd0aCA9PT0gMCkgewogICAgICAgICAgICAgICAgICAgIGxhenlMb2FkSW5zdGFuY2UudXBkYXRlKCk7CiAgICAgICAgICAgICAgICAgICAgY29uc29sZS5sb2coInVwZGF0ZSIpOwogICAgICAgICAgICAgICAgICAgIHJldHVybiB0aGlzLnBob3RvczsKICAgICAgICAgICAgICAgIH0KICAgICAgICAgICAgICAgIGxldCByID0gW107CiAgICAgICAgICAgICAgICBmb3IgKGxldCBpID0gMDsgaSA8IHRoaXMucGhvdG9zLmxlbmd0aDsgaSsrKSB7CiAgICAgICAgICAgICAgICAgICAgZm9yIChsZXQgaiA9IDA7IGogPCBsaW5lcy5sZW5ndGg7IGorKykgewogICAgICAgICAgICAgICAgICAgICAgICBpZiAodGhpcy5waG90b3NbaV0ubmFtZS5pbmRleE9mKGxpbmVzW2pdKSAhPT0gLTEpIHsKICAgICAgICAgICAgICAgICAgICAgICAgICAgIHIucHVzaCh0aGlzLnBob3Rvc1tpXSk7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICBicmVhawogICAgICAgICAgICAgICAgICAgICAgICB9CiAgICAgICAgICAgICAgICAgICAgfQogICAgICAgICAgICAgICAgfQoKICAgICAgICAgICAgICAgIGxhenlMb2FkSW5zdGFuY2UudXBkYXRlKCk7CiAgICAgICAgICAgICAgICBjb25zb2xlLmxvZygidXBkYXRlIik7CiAgICAgICAgICAgICAgICByZXR1cm4gcjsKICAgICAgICAgICAgfSwKICAgICAgICAgICAgZmlsdGVyZWRDb21tZW50cygpIHsKICAgICAgICAgICAgICAgIGxldCBsaW5lcyA9IHRoaXMuY29tbWVudHNLZXl3b3JkLnNwbGl0KCJcbiIpLmZpbHRlcih4ID0+IHgudHJpbSgpICE9PSAiIikubWFwKHggPT4geC50cmltKCkpOwogICAgICAgICAgICAgICAgaWYgKGxpbmVzLmxlbmd0aCA9PT0gMCkgewogICAgICAgICAgICAgICAgICAgIHJldHVybiB0aGlzLmNvbW1lbnRzOwogICAgICAgICAgICAgICAgfQogICAgICAgICAgICAgICAgbGV0IHIgPSBbXTsKICAgICAgICAgICAgICAgIGZvciAobGV0IGkgPSAwOyBpIDwgdGhpcy5jb21tZW50cy5sZW5ndGg7IGkrKykgewogICAgICAgICAgICAgICAgICAgIGZvciAobGV0IGogPSAwOyBqIDwgbGluZXMubGVuZ3RoOyBqKyspIHsKICAgICAgICAgICAgICAgICAgICAgICAgaWYgKHRoaXMuY29tbWVudHNbaV0uaW5kZXhPZihsaW5lc1tqXSkgIT09IC0xKSB7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICByLnB1c2godGhpcy5jb21tZW50c1tpXSk7CiAgICAgICAgICAgICAgICAgICAgICAgICAgICBicmVhawogICAgICAgICAgICAgICAgICAgICAgICB9CiAgICAgICAgICAgICAgICAgICAgfQogICAgICAgICAgICAgICAgfQogICAgICAgICAgICAgICAgcmV0dXJuIHI7CiAgICAgICAgICAgIH0sCiAgICAgICAgICAgIGZpbHRlcmVkTWVzc2FnZXMoKSB7CiAgICAgICAgICAgICAgICBsZXQgbGluZXMgPSB0aGlzLm1lc3NhZ2VzS2V5d29yZC5zcGxpdCgiXG4iKS5maWx0ZXIoeCA9PiB4LnRyaW0oKSAhPT0gIiIpLm1hcCh4ID0+IHgudHJpbSgpKTsKICAgICAgICAgICAgICAgIGlmIChsaW5lcy5sZW5ndGggPT09IDApIHsKICAgICAgICAgICAgICAgICAgICByZXR1cm4gdGhpcy5tZXNzYWdlczsKICAgICAgICAgICAgICAgIH0KICAgICAgICAgICAgICAgIGxldCByID0gW107CiAgICAgICAgICAgICAgICBmb3IgKGxldCBpID0gMDsgaSA8IHRoaXMubWVzc2FnZXMubGVuZ3RoOyBpKyspIHsKICAgICAgICAgICAgICAgICAgICBmb3IgKGxldCBqID0gMDsgaiA8IGxpbmVzLmxlbmd0aDsgaisrKSB7CiAgICAgICAgICAgICAgICAgICAgICAgIGlmICh0aGlzLm1lc3NhZ2VzW2ldLmluZGV4T2YobGluZXNbal0pICE9PSAtMSkgewogICAgICAgICAgICAgICAgICAgICAgICAgICAgci5wdXNoKHRoaXMubWVzc2FnZXNbaV0pOwogICAgICAgICAgICAgICAgICAgICAgICAgICAgYnJlYWsKICAgICAgICAgICAgICAgICAgICAgICAgfQogICAgICAgICAgICAgICAgICAgIH0KICAgICAgICAgICAgICAgIH0KICAgICAgICAgICAgICAgIHJldHVybiByOwogICAgICAgICAgICB9CiAgICAgICAgfQogICAgfSkKPC9zY3JpcHQ+CjwvYm9keT4KPC9odG1sPg==");

	internal static int int_1 = 0;

	internal static GClass14 FA2640AB = null;

	internal static bool bool_0 = false;

	internal static bool bool_1 = false;

	public static string D5875C8F()
	{
		string result = "https://xyz.minsoftware.vn";
		int num = SettingsTool.GetSettings("configGeneral").method_0("type");
		int num2 = num;
		int num3 = num2;
		if (num3 == 1)
		{
			C891C93E("EN");
			result = "https://app.minsoftthailand.com";
		}
		return result;
	}

	public static string BD8E591F()
	{
		string result = FileHelper.GetPathToCurrentFolder();
		if (SettingsTool.GetSettings("configGeneral").AA824D29("ckbDongBoMaxCare") && Directory.Exists(SettingsTool.GetSettings("configGeneral").GetValue("txtPathMaxCare")))
		{
			result = SettingsTool.GetSettings("configGeneral").GetValue("txtPathMaxCare");
		}
		return result;
	}

	public static string smethod_0()
	{
		return SettingsTool.GetSettings("configGeneral").GetValue("Language", "VN");
	}

	public static void C891C93E(string F0375182 = "VN")
	{
        SettingsTool.GetSettings("configGeneral").GetValue("Language", (object)F0375182);
		SettingsTool.smethod_0("configGeneral");
	}
}