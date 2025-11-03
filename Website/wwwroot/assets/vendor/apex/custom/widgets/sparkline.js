var options1 = {
	series: [
		{
			data: [12, 14, 2, 47, 42, 15, 47, 75, 65, 19, 14],
		},
	],
	chart: {
		type: "line",
		width: 180,
		height: 35,
		sparkline: {
			enabled: true,
		},
	},
	colors: ["#f27436", "#cccccc"],
	tooltip: {
		fixed: {
			enabled: false,
		},
		x: {
			show: false,
		},
		y: {
			title: {
				formatter: function (seriesName) {
					return "";
				},
			},
		},
		marker: {
			show: false,
		},
	},
};

var chart1 = new ApexCharts(document.querySelector("#option1"), options1);
chart1.render();

// Sparkline 2
var options2 = {
	series: [
		{
			data: [12, 14, 2, 47, 42, 15, 47, 75, 65, 19, 14],
		},
	],
	chart: {
		type: "line",
		width: 180,
		height: 35,
		sparkline: {
			enabled: true,
		},
	},
	colors: ["#f27436", "#cccccc"],
	tooltip: {
		fixed: {
			enabled: false,
		},
		x: {
			show: false,
		},
		y: {
			title: {
				formatter: function (seriesName) {
					return "";
				},
			},
		},
		marker: {
			show: false,
		},
	},
};

var chart2 = new ApexCharts(document.querySelector("#option2"), options2);
chart2.render();

// Sparkline 3
var options3 = {
	series: [
		{
			data: [12, 14, 2, 47, 42, 15, 47, 75, 65, 19, 14],
		},
	],
	chart: {
		type: "line",
		width: 180,
		height: 35,
		sparkline: {
			enabled: true,
		},
	},
	colors: ["#f27436", "#cccccc"],
	tooltip: {
		fixed: {
			enabled: false,
		},
		x: {
			show: false,
		},
		y: {
			title: {
				formatter: function (seriesName) {
					return "";
				},
			},
		},
		marker: {
			show: false,
		},
	},
};

var chart3 = new ApexCharts(document.querySelector("#option3"), options3);
chart3.render();
