var options = {
	series: [75],
	chart: {
		height: 240,
		type: "radialBar",
		offsetY: -10,
	},
	plotOptions: {
		radialBar: {
			startAngle: -135,
			endAngle: 135,
			dataLabels: {
				name: {
					fontSize: "16px",
					color: undefined,
					offsetY: 120,
				},
				value: {
					offsetY: 76,
					fontSize: "21px",
					color: undefined,
					formatter: function (val) {
						return val + "%";
					},
				},
			},
		},
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
	stroke: {
		dashArray: 4,
	},
	labels: ["Sales Ratio"],
};

var chart = new ApexCharts(document.querySelector("#gauge"), options);
chart.render();
