var options = {
	chart: {
		width: 300,
		type: "donut",
	},
	labels: ["Team A", "Team B", "Team C", "Team D", "Team E"],
	series: [20, 35, 45, 65, 40],
	legend: {
		position: "bottom",
	},
	dataLabels: {
		enabled: false,
	},
	stroke: {
		width: 0,
	},
	colors: [
		"#493f94",
		"#5247a7",
		"#5b4fb9",
		"#6b61c0",
		"#7c72c7",
		"#8c84ce",
		"#9d95d5",
		"#ada7dc",
		"#bdb9e3",
		"#cecaea",
	],
};
var chart = new ApexCharts(document.querySelector("#donut"), options);
chart.render();
