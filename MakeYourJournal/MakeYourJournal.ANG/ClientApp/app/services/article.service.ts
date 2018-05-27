﻿import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from "rxjs/Observable";

import 'rxjs/add/operator/map'

import Article from '../models/article.model';

@Injectable()
export class ArticleService {

    constructor(
        private http: Http,
        @Inject('BASE_URL') private baseUrl: string) {
    }

    getAllArticle(issueId: number): Observable<Article[]> {
        return this.http.get(this.baseUrl + 'api/Article/GetByIssue/' + issueId)
            .map(response => response.json())
            .catch(this.handleError);
    }

    addArticle(newArticle: Article) {
        this.http.post(this.baseUrl + 'api/Article', JSON.stringify(newArticle));
    }

    deleteArticle(articleId: number) {
        this.http.delete(this.baseUrl + 'api/Article/' + articleId);
    }

    private handleError(error: any): Observable<any> {
        console.error('An error occurred', error);
        return Observable.throw(error);
    }
}
