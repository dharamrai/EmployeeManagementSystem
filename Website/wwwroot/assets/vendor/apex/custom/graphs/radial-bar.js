var options = {
	series: [40, 50, 60, 70, 80],
	chart: {
		height: 240,
		type: "radialBar",
	},
	plotOptions: {
		radialBar: {
			dataLabels: {
				name: {
					fontSize: "22px",
				},
				value: {
					fontSize: "16px",
				},
				total: {
					show: true,
					label: "Total",
					formatter: function (w) {
						// By default this function returns the average of all series. The below is just an example to show the use of custom formatter function
						return 249;
					},
				},
			},
		},
	},
	labels: ["Samsung", "Apple", "Nokia", "Motorola", "Huawei"],
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

var chart = new ApexCharts(document.querySelector("#radial"), options);
chart.render();
