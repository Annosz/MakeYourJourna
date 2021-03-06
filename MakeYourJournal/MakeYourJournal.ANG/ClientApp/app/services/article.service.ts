﻿import { Injectable, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Observable } from "rxjs/Observable";

import 'rxjs/add/operator/map'

import Article from '../models/article.model';

@Injectable()
export class ArticleService {
    private headers = new Headers();
    
    constructor(
        private http: Http,
        @Inject('BASE_URL') private baseUrl: string) {
        this.headers.append('Content-Type', 'application/json; charset=utf-8');
    }

    getAllArticle(allTime: number): Observable<Article[]> {
        return this.http.get(this.baseUrl + 'api/v2/Article/GetByIssue/' + allTime)
            .map(response => response.json())
            .catch(this.handleError);
    }

    addArticle(newArticle: Article): Observable<Article> {
        return this.http.post(this.baseUrl + 'api/v1/Article', JSON.stringify(newArticle), { headers: this.headers })
            .map(response => response.json())
            .catch(this.handleError);
    }

    deleteArticle(articleId: number) {
        this.http.delete(this.baseUrl + 'api/v1/Article/' + articleId)
            .subscribe(data => { }, error => console.error('Could not delete article.'));
    }

    private handleError(error: any): Observable<any> {
        console.error('An error occurred', error);
        return Observable.throw(error);
    }
}
