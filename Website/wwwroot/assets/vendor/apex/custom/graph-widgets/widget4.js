// Graph 1
var options = {
	series: [40],
	chart: {
		height: 350,
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
					fontSize: "22px",
					color: undefined,
					formatter: function (val) {
						return val + "%";
					},
				},
			},
		},
	},
	colors: ["#5b4fb9"],
	stroke: {
		dashArray: 4,
	},
	labels: ["Income"],
};
var chart = new ApexCharts(document.querySelector("#income"), options);
chart.render();

// Graph 2
var options2 = {
	series: [60],
	chart: {
		height: 350,
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
					fontSize: "22px",
					color: undefined,
					formatter: function (val) {
						return val + "%";
					},
				},
			},
		},
	},
	colors: ["#5b4fb9"],
	stroke: {
		dashArray: 4,
	},
	labels: ["Expenses"],
};
var chart2 = new ApexCharts(document.querySelector("#expenses"), options2);
chart2.render();

// Graph 3
var options3 = {
	series: [80],
	chart: {
		height: 350,
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
					fontSize: "22px",
					color: undefined,
					formatter: function (val) {
						return val + "%";
					},
				},
			},
		},
	},
	colors: ["#f27436"],
	stroke: {
		dashArray: 4,
	},
	labels: ["Revenue"],
};
var chart3 = new ApexCharts(document.querySelector("#revenue"), options3);
chart3.render();
