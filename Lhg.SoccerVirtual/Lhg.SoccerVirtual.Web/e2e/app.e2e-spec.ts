import { Lhg.SoccerVirtual.WebPage } from './app.po';

describe('lhg.soccer-virtual.web App', () => {
  let page: Lhg.SoccerVirtual.WebPage;

  beforeEach(() => {
    page = new Lhg.SoccerVirtual.WebPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
