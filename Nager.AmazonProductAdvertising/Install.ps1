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
	#Spain
	1034
	{
		$url = "https://www.amazon.es/?tag=nageres-21"
	}
	#France
	1036
	{
		$url = "https://www.amazon.fr/?tag=nagerfr-21"
	}
	#United Kingdom
	2057
	{
		$url = "https://www.amazon.co.uk/?tag=nageruk-21"
	}
	#Italy
	1040
	{
		$url = "https://www.amazon.it/?tag=nagerit-21"
	}
}

Start-Process -FilePath $url