var options = {
  series: [
    {
      name: "",
      data: [200, 330, 548, 740, 880, 1100, 1380],
    },
  ],
  chart: {
    type: "bar",
    height: 280,
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
  colors: ["#ff7d41", "#ff41d3", "#796dd8", "#69c0f8", "#6eb960", "#111111"],
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
    categories: [
      "Meat",
      "Dairy",
      "Grains",
      "Gadgets",
      "Electronics",
      "Processed Foods",
      "Fruits & Vegetables",
    ],
  },
  legend: {
    show: false,
  },
  tooltip: {
    y: {
      formatter: function (val) {
        return + val;
      },
    },
    theme: 'dark',
  },
};

var chart = new ApexCharts(document.querySelector("#orders"), options);
chart.render();