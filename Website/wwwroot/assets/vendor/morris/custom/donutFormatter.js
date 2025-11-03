Morris.Donut({
	element: "donutFormatter",
	data: [
		{ value: 155, label: "voo", formatted: "at least 70%" },
		{ value: 12, label: "bar", formatted: "approx. 15%" },
		{ value: 10, label: "baz", formatted: "approx. 10%" },
		{ value: 5, label: "A really really long label", formatted: "at most 5%" },
	],
	resize: true,
	hideHover: "auto",
	formatter: function (x, data) {
		return data.formatted;
	},
	labelColor: "#594323",
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
});
