var options = {
	series: [
		{
			name: "Tickets",
			data: [200, 330, 548, 740, 880, 1100],
		},
	],
	chart: {
		type: "bar",
		height: 300,
		toolbar: {
			show: false,
		},
	},
	dataLabels: {
		enabled: false,
	},
	plotOptions: {
		bar: {
			borderRadius: 0,
			horizontal: true,
			distributed: true,
			barHeight: "80%",
			isFunnel: true,
		},
	},
	colors: [
		"#333333",
		"#444444",
		"#555555",
		"#666666",
		"#777777",
		"#888888",
		"#999999",
		"#AAAAAA",
	],
	dataLabels: {
		enabled: true,
		formatter: function (val, opt) {
			return opt.w.globals.labels[opt.dataPointIndex];
		},
		dropShadow: {
			enabled: true,
		},
	},
	xaxis: {
		categories: ["Closed", "Hold", "Resolved", "Waiting", "On Going", "Total"],
	},
	legend: {
		show: true,
	},
};

var chart = new ApexCharts(document.querySelector("#calls"), options);
chart.render();
