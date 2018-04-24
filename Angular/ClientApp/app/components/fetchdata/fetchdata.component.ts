import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})

export class FetchDataComponent {
    public forecasts: WeatherForecast[];

    public cacheForecasts: WeatherForecast[];
    public summaries: any[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        //forecasts
        http.get(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
            this.forecasts = result.json() as WeatherForecast[];
            this.cacheForecasts = this.forecasts;
        }, error => console.error(error));
        //Summaries
        http.get(baseUrl + 'api/SampleData/GetSummaries').subscribe(x => {
            this.summaries = x.json() as any[];
        }, error => console.error(error));
    }

    filterForeCasts(filterVal: any) {
        if (filterVal == "0")
            this.forecasts = this.cacheForecasts;
        else
            this.forecasts = this.cacheForecasts.filter((item) => item.summary == filterVal);
    }
}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}

interface Summary {
    name: string;
}
