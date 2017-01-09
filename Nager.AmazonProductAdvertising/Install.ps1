param($installPath, $toolsPath, $package, $project)

$lcid = (Get-Culture).LCID
$url = "https://www.amazon.com/?tag=nager-20"

switch ($lcid) 
{
	#Germany
	1031
	{
		$url = "https://www.amazon.de/?tag=nagerat-21"
	}
	#Austria
	3079
	{
		$url = "https://www.amazon.de/?tag=nagerat-21"
	}
	#Switzerland
	2055
	{
		$url = "https://www.amazon.de/?tag=nagerat-21"
	}
}

Start-Process -FilePath $url